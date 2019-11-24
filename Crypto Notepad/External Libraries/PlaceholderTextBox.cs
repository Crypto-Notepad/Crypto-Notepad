using System.Drawing;
using System.ComponentModel;

namespace System.Windows.Forms
{
    public class PlaceholderTextBox : TextBox
    {
        #region Fields

        #region Protected Fields

        protected string _placeholderText = "Default placeholder"; //The placeholder text
        protected Color _placeholderColor; //Color of the placeholder when the control does not have focus
        protected Color _placeholderActiveColor; //Color of the placeholder when the control has focus

        #endregion

        #region Private Fields

        private Panel placeholderContainer; //Container to hold the placeholder
        private Font placeholderFont; //Font of the placeholder
        private SolidBrush placeholderBrush; //Brush for the placeholder

        #endregion

        #endregion

        #region Constructors

        public PlaceholderTextBox()
        {
            Initialize();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Initializes placeholder properties and adds CtextBox events
        /// </summary>
        private void Initialize()
        {
            //Sets some default values to the placeholder properties
            _placeholderColor = Color.LightGray;
            _placeholderActiveColor = Color.Gray;
            placeholderFont = Font;
            placeholderBrush = new SolidBrush(_placeholderActiveColor);
            placeholderContainer = null;

            //Draw the placeholder, so we can see it in design time
            DrawPlaceholder();

            //Eventhandlers which contains function calls. 
            //Either to draw or to remove the placeholder
            Enter += new EventHandler(ThisHasFocus);
            Leave += new EventHandler(ThisWasLeaved);
            TextChanged += new EventHandler(ThisTextChanged);
        }

        /// <summary>
        /// Removes the placeholder if it should
        /// </summary>
        private void RemovePlaceholder()
        {
            if (placeholderContainer != null)
            {
                Controls.Remove(placeholderContainer);
                placeholderContainer = null;
            }
        }

        /// <summary>
        /// Draws the placeholder if the text length is 0
        /// </summary>
        private void DrawPlaceholder()
        {
            if (placeholderContainer == null && TextLength <= 0)
            {
                placeholderContainer = new Panel(); // Creates the new panel instance
                placeholderContainer.Paint += new PaintEventHandler(placeholderContainer_Paint);
                placeholderContainer.Invalidate();
                placeholderContainer.Click += new EventHandler(placeholderContainer_Click);
                Controls.Add(placeholderContainer); // adds the control
            }
        }

        #endregion

        #region Eventhandlers

        #region Placeholder Events

        private void placeholderContainer_Click(object sender, EventArgs e)
        {
            Focus(); //Makes sure you can click wherever you want on the control to gain focus
        }

        private void placeholderContainer_Paint(object sender, PaintEventArgs e)
        {
            //Setting the placeholder container up
            placeholderContainer.Location = new Point(2, 0); // sets the location
            placeholderContainer.Height = Height; // Height should be the same as its parent
            placeholderContainer.Width = Width; // same goes for width and the parent
            placeholderContainer.Anchor = AnchorStyles.Left | AnchorStyles.Right; // makes sure that it resizes with the parent control



            if (ContainsFocus)
            {
                //if focused use normal color
                placeholderBrush = new SolidBrush(_placeholderActiveColor);
            }

            else
            {
                //if not focused use not active color
                placeholderBrush = new SolidBrush(_placeholderColor);
            }

            //Drawing the string into the panel 
            Graphics g = e.Graphics;
            g.DrawString(_placeholderText, placeholderFont, placeholderBrush, new PointF(-2f, 1f));//Take a look at that point
            //The reason I'm using the panel at all, is because of this feature, that it has no limits
            //I started out with a label but that looked very very bad because of its paddings 

        }

        #endregion

        #region CTextBox Events

        private void ThisHasFocus(object sender, EventArgs e)
        {
            //if focused use focus color
            placeholderBrush = new SolidBrush(_placeholderActiveColor);

            //The placeholder should not be drawn if the user has already written some text
            if (TextLength <= 0)
            {
                RemovePlaceholder();
                DrawPlaceholder();
            }
        }

        private void ThisWasLeaved(object sender, EventArgs e)
        {
            //if the user has written something and left the control
            if (TextLength > 0)
            {
                //Remove the placeholder
                RemovePlaceholder();
            }
            else
            {
                //But if the user didn't write anything, Then redraw the control.
                Invalidate();
            }
        }

        private void ThisTextChanged(object sender, EventArgs e)
        {
            //If the text of the textbox is not empty
            if (TextLength > 0)
            {
                //Remove the placeholder
                RemovePlaceholder();
            }
            else
            {
                //But if the text is empty, draw the placeholder again.
                DrawPlaceholder();
            }
        }

        #region Overrided Events

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Draw the placeholder even in design time
            DrawPlaceholder();
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            //Check if there is a placeholder
            if (placeholderContainer != null)
                //if there is a placeholder it should also be invalidated();
                placeholderContainer.Invalidate();
        }

        #endregion

        #endregion

        #endregion

        #region Properties
        [Category("Placeholder attribtues")]
        [Description("Sets the text of the placeholder")]
        public string Placeholder
        {
            get { return _placeholderText; }
            set
            {
                _placeholderText = value;
                Invalidate();
            }
        }

        [Category("Placeholder attribtues")]
        [Description("When the control gaines focus, this color will be used as the placeholder's forecolor")]
        public Color PlaceholderActiveForeColor
        {
            get { return _placeholderActiveColor; }

            set
            {
                _placeholderActiveColor = value;
                Invalidate();
            }
        }

        [Category("Placeholder attribtues")]
        [Description("When the control looses focus, this color will be used as the placeholder's forecolor")]
        public Color PlaceholderForeColor
        {
            get { return _placeholderColor; }

            set
            {
                _placeholderColor = value;
                Invalidate();
            }
        }

        [Category("Placeholder attribtues")]
        [Description("The font used on the watermark. Default is the same as the control")]
        public Font PlaceholderFont
        {
            get
            {
                return placeholderFont;
            }

            set
            {
                placeholderFont = value;
                Invalidate();
            }
        }

        #endregion
    }
}
