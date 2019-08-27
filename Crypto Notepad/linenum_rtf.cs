using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Diagnostics;
using System.Windows.Forms;


namespace LineNumbers
{
	[System.ComponentModel.DefaultProperty("ParentRichTextBox")]
	public class LineNumbers_For_RichTextBox : System.Windows.Forms.Control
	{

		private class LineNumberItem
		{
			internal int LineNumber;
			internal Rectangle Rectangle;
			internal LineNumberItem(int zLineNumber, Rectangle zRectangle)
			{
				this.LineNumber = zLineNumber;
				this.Rectangle = zRectangle;
			}
		}

		public enum LineNumberDockSide : byte
		{
			None = 0,
			Left = 1,
			Right = 2,
			Height = 4
		}
		private RichTextBox withEventsField_zParent = null;

		private RichTextBox zParent {
			get { return withEventsField_zParent; }
			set {
				if (withEventsField_zParent != null) {
					withEventsField_zParent.LocationChanged -= zParent_Changed;
					withEventsField_zParent.Move -= zParent_Changed;
					withEventsField_zParent.Resize -= zParent_Changed;
					withEventsField_zParent.DockChanged -= zParent_Changed;
					withEventsField_zParent.TextChanged -= zParent_Changed;
					withEventsField_zParent.MultilineChanged -= zParent_Changed;
					withEventsField_zParent.HScroll -= zParent_Scroll;
					withEventsField_zParent.VScroll -= zParent_Scroll;
					withEventsField_zParent.ContentsResized -= zParent_ContentsResized;
					withEventsField_zParent.Disposed -= zParent_Disposed;
				}
				withEventsField_zParent = value;
				if (withEventsField_zParent != null) {
					withEventsField_zParent.LocationChanged += zParent_Changed;
					withEventsField_zParent.Move += zParent_Changed;
					withEventsField_zParent.Resize += zParent_Changed;
					withEventsField_zParent.DockChanged += zParent_Changed;
					withEventsField_zParent.TextChanged += zParent_Changed;
					withEventsField_zParent.MultilineChanged += zParent_Changed;
					withEventsField_zParent.HScroll += zParent_Scroll;
					withEventsField_zParent.VScroll += zParent_Scroll;
					withEventsField_zParent.ContentsResized += zParent_ContentsResized;
					withEventsField_zParent.Disposed += zParent_Disposed;
				}
			}
		}
		
		//private Windows.Forms.Timer withEventsField_zTimer = new Windows.Forms.Timer();
		//private Windows.Forms.Timer zTimer {
		//private Timer withEventsField_zTimer = new Windows.Forms.Timer();
		private Timer withEventsField_zTimer = new Timer();
		private Timer zTimer
		{
			get { return withEventsField_zTimer; }
			set {
				if (withEventsField_zTimer != null) {
					withEventsField_zTimer.Tick -= zTimer_Tick;
				}
				withEventsField_zTimer = value;
				if (withEventsField_zTimer != null) {
					withEventsField_zTimer.Tick += zTimer_Tick;
				}
			}

		}
		private bool zAutoSizing = true;
		private Size zAutoSizing_Size = new Size(0, 0);
		//private Rectangle zContentRectangle = null;
		private Rectangle zContentRectangle;
		private LineNumberDockSide zDockSide = LineNumberDockSide.Left;
		private bool zParentIsScrolling = false;

		private bool zSeeThroughMode = false;
		private bool zGradient_Show = true;
		private System.Drawing.Drawing2D.LinearGradientMode zGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
		private Color zGradient_StartColor = Color.FromArgb(0, 0, 0, 0);

		private Color zGradient_EndColor = Color.Transparent;
		private bool zGridLines_Show = true;
		private float zGridLines_Thickness = 1;
		private System.Drawing.Drawing2D.DashStyle zGridLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;

		private Color zGridLines_Color = Color.SlateGray;
		private bool zBorderLines_Show = true;
		private float zBorderLines_Thickness = 1;
		private System.Drawing.Drawing2D.DashStyle zBorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;

		private Color zBorderLines_Color = Color.SlateGray;
		private bool zMarginLines_Show = true;
		private LineNumberDockSide zMarginLines_Side = LineNumberDockSide.Right;
		private float zMarginLines_Thickness = 1;
		private System.Drawing.Drawing2D.DashStyle zMarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;

		private Color zMarginLines_Color = Color.SlateGray;
		private bool zLineNumbers_Show = true;
		private bool zLineNumbers_ShowLeadingZeroes = true;
		private bool zLineNumbers_ShowAsHexadecimal = false;
		private bool zLineNumbers_ClipByItemRectangle = true;
		private Size zLineNumbers_Offset = new Size(0, 0);
		private string zLineNumbers_Format = "0";
		private System.Drawing.ContentAlignment zLineNumbers_Alignment = ContentAlignment.TopRight;
		
		private bool zLineNumbers_AntiAlias = true;

		private List<LineNumberItem> zLNIs = new List<LineNumberItem>();
		private Point zPointInParent = new Point(0, 0);
		private Point zPointInMe = new Point(0, 0);
		private int zParentInMe = 0;
		////////////////////////////////////////////////////////////////////////////////////////////////////

		public LineNumbers_For_RichTextBox()
		{
			{
				this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
				this.SetStyle(ControlStyles.ResizeRedraw, true);
				this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
				this.SetStyle(ControlStyles.UserPaint, true);
				this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
				this.Margin = new Padding(0);
				this.Padding = new Padding(0, 0, 2, 0);
			}
			{
				zTimer.Enabled = true;
				zTimer.Interval = 200;
				zTimer.Stop();
			}
			this.Update_SizeAndPosition();
			this.Invalidate();
		}

		protected override void OnHandleCreated(System.EventArgs e)
		{
			base.OnHandleCreated(e);
			this.AutoSize = false;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////////

		[System.ComponentModel.Browsable(false)]
		public override bool AutoSize {
			get { return base.AutoSize; }
			set {
				base.AutoSize = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("Use this property to automatically resize the control (and reposition it if needed).")]
		[System.ComponentModel.Category("Additional Behavior")]
		public bool AutoSizing {
			get { return zAutoSizing; }
			set {
				zAutoSizing = value;
				this.Refresh();
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("Use this property to enable LineNumbers for the chosen RichTextBox.")]
		[System.ComponentModel.Category("Add LineNumbers to")]
		public RichTextBox ParentRichTextBox {
			get { return zParent; }
			set {
				zParent = value;
				if (zParent != null) {
					this.Parent = zParent.Parent;
					zParent.Refresh();
				}
				this.Text = "";
				this.Refresh();
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("Use this property to dock the LineNumbers to a chosen side of the chosen RichTextBox.")]
		[System.ComponentModel.Category("Additional Behavior")]
		public LineNumberDockSide DockSide {
			get { return zDockSide; }
			set {
				zDockSide = value;
				this.Refresh();
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("Use this property to enable the control to act as an overlay ontop of the RichTextBox.")]
		[System.ComponentModel.Category("Additional Behavior")]
		public bool _SeeThroughMode_ {
			get { return zSeeThroughMode; }
			set {
				zSeeThroughMode = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("BorderLines are shown on all sides of the LineNumber control.")]
		[System.ComponentModel.Category("Additional Behavior")]
		public bool Show_BorderLines {
			get { return zBorderLines_Show; }
			set {
				zBorderLines_Show = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public Color BorderLines_Color {
			get { return zBorderLines_Color; }
			set {
				zBorderLines_Color = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public float BorderLines_Thickness {
			get { return zBorderLines_Thickness; }
			set {
				zBorderLines_Thickness = Math.Max(1, Math.Min(255, value));
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public System.Drawing.Drawing2D.DashStyle BorderLines_Style
		{
			get { return zBorderLines_Style; }
			set {
				if (value == System.Drawing.Drawing2D.DashStyle.Custom)
					value = System.Drawing.Drawing2D.DashStyle.Solid;
				zBorderLines_Style = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("GridLines are the horizontal divider-lines shown above each LineNumber.")]
		[System.ComponentModel.Category("Additional Behavior")]
		public bool Show_GridLines {
			get { return zGridLines_Show; }
			set {
				zGridLines_Show = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public Color GridLines_Color {
			get { return zGridLines_Color; }
			set {
				zGridLines_Color = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public float GridLines_Thickness {
			get { return zGridLines_Thickness; }
			set {
				zGridLines_Thickness = Math.Max(1, Math.Min(255, value));
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public System.Drawing.Drawing2D.DashStyle GridLines_Style
		{
			get { return zGridLines_Style; }
			set {
				if (value == System.Drawing.Drawing2D.DashStyle.Custom)
					value = System.Drawing.Drawing2D.DashStyle.Solid;
				zGridLines_Style = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("MarginLines are shown on the Left or Right (or both in Height-mode) of the LineNumber control.")]
		[System.ComponentModel.Category("Additional Behavior")]
		public bool Show_MarginLines {
			get { return zMarginLines_Show; }
			set {
				zMarginLines_Show = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public LineNumberDockSide MarginLines_Side {
			get { return zMarginLines_Side; }
			set {
				zMarginLines_Side = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public Color MarginLines_Color {
			get { return zMarginLines_Color; }
			set {
				zMarginLines_Color = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public float MarginLines_Thickness {
			get { return zMarginLines_Thickness; }
			set {
				zMarginLines_Thickness = Math.Max(1, Math.Min(255, value));
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public System.Drawing.Drawing2D.DashStyle MarginLines_Style
		{
			get { return zMarginLines_Style; }
			set {
				if (value == System.Drawing.Drawing2D.DashStyle.Custom)
					value = System.Drawing.Drawing2D.DashStyle.Solid;
				zMarginLines_Style = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("The BackgroundGradient is a gradual blend of two colors, shown in the back of each LineNumber's item-area.")]
		[System.ComponentModel.Category("Additional Behavior")]
		public bool Show_BackgroundGradient {
			get { return zGradient_Show; }
			set {
				zGradient_Show = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public Color BackgroundGradient_AlphaColor {
			get { return zGradient_StartColor; }
			set {
				zGradient_StartColor = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public Color BackgroundGradient_BetaColor {
			get { return zGradient_EndColor; }
			set {
				zGradient_EndColor = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Appearance")]
		public System.Drawing.Drawing2D.LinearGradientMode BackgroundGradient_Direction
		{
			get { return zGradient_Direction; }
			set {
				zGradient_Direction = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Category("Additional Behavior")]
		public bool Show_LineNrs {
			get { return zLineNumbers_Show; }
			set {
				zLineNumbers_Show = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("Use this to set whether the LineNumbers are allowed to spill out of their item-area, or should be clipped by it.")]
		[System.ComponentModel.Category("Additional Behavior")]
		public bool LineNrs_ClippedByItemRectangle {
			get { return zLineNumbers_ClipByItemRectangle; }
			set {
				zLineNumbers_ClipByItemRectangle = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("Use this to set whether the LineNumbers should have leading zeroes (based on the total amount of textlines).")]
		[System.ComponentModel.Category("Additional Behavior")]
		public bool LineNrs_LeadingZeroes {
			get { return zLineNumbers_ShowLeadingZeroes; }
			set {
				zLineNumbers_ShowLeadingZeroes = value;
				this.Refresh();
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("Use this to set whether the LineNumbers should be shown as hexadecimal values.")]
		[System.ComponentModel.Category("Additional Behavior")]
		public bool LineNrs_AsHexadecimal {
			get { return zLineNumbers_ShowAsHexadecimal; }
			set {
				zLineNumbers_ShowAsHexadecimal = value;
				this.Refresh();
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("Use this property to manually reposition the LineNumbers, relative to their current location.")]
		[System.ComponentModel.Category("Additional Behavior")]
		public Size LineNrs_Offset {
			get { return zLineNumbers_Offset; }
			set {
				zLineNumbers_Offset = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("Use this to align the LineNumbers to a chosen corner (or center) within their item-area.")]
		[System.ComponentModel.Category("Additional Behavior")]
		public System.Drawing.ContentAlignment LineNrs_Alignment {
			get { return zLineNumbers_Alignment; }
			set {
				zLineNumbers_Alignment = value;
				this.Invalidate();
			}
		}

		[System.ComponentModel.Description("Use this to apply Anti-Aliasing to the LineNumbers (high quality). Some fonts will look better without it, though.")]
		[System.ComponentModel.Category("Additional Behavior")]
		public bool LineNrs_AntiAlias {
			get { return zLineNumbers_AntiAlias; }
			set {
				zLineNumbers_AntiAlias = value;
				this.Refresh();
				this.Invalidate();
			}
		}

		[System.ComponentModel.Browsable(true)]
		public override System.Drawing.Font Font {
			get { return base.Font; }
			set {
				base.Font = value;
				this.Refresh();
				this.Invalidate();
			}
		}

		[System.ComponentModel.DefaultValue("")]
		[System.ComponentModel.AmbientValue("")]
		[System.ComponentModel.Browsable(false)]
		public override string Text {
			get { return base.Text; }
			set {
				base.Text = "";
				this.Invalidate();
			}
		}


		////////////////////////////////////////////////////////////////////////////////////////////////////

		protected override void OnSizeChanged(System.EventArgs e)
		{
			if (this.DesignMode == true)
				this.Refresh();
			base.OnSizeChanged(e);
			this.Invalidate();
		}

		protected override void OnLocationChanged(System.EventArgs e)
		{
			if (this.DesignMode == true)
				this.Refresh();
			base.OnLocationChanged(e);
			this.Invalidate();
		}

		public override void Refresh()
		{
			//   Note: don't change the order here, first the Mybase.Refresh, then the Update_SizeAndPosition.
			base.Refresh();
			this.Update_SizeAndPosition();
		}

		/// <summary>
		/// This Sub will run whenever Me.Refresh() is called. It applies the AutoSizing and DockSide settings.
		/// </summary>
		/// <remarks></remarks>
		private void Update_SizeAndPosition()
		{
			if (this.AutoSize == true)
				return;
			if (this.Dock == DockStyle.Bottom | this.Dock == DockStyle.Fill | this.Dock == DockStyle.Top)
				return;
			Point zNewLocation = this.Location;
			Size zNewSize = this.Size;

			if (zAutoSizing == true) {
				//switch (true) {
				//	case zParent == null:
				if (zParent == null ){
						// --- ReminderMessage sizing
						if (zAutoSizing_Size.Width > 0)
							zNewSize.Width = zAutoSizing_Size.Width;
						if (zAutoSizing_Size.Height > 0)
							zNewSize.Height = zAutoSizing_Size.Height;
						this.Size = zNewSize;

						// break;
				}else if (this.Dock == DockStyle.Left | this.Dock == DockStyle.Right){
					//--- zParent isNot Nothing for the following cases
					//case this.Dock == DockStyle.Left | this.Dock == DockStyle.Right:
						if (zAutoSizing_Size.Width > 0)
							zNewSize.Width = zAutoSizing_Size.Width;
						this.Width = zNewSize.Width;

						//break;
				}else if (zDockSide != LineNumberDockSide.None){
					// --- DockSide is active L/R/H
					//case zDockSide != LineNumberDockSide.None:
						if (zAutoSizing_Size.Width > 0)
							zNewSize.Width = zAutoSizing_Size.Width;
						zNewSize.Height = zParent.Height;
						if (zDockSide == LineNumberDockSide.Left)
							zNewLocation.X = zParent.Left - zNewSize.Width - 1;
						if (zDockSide == LineNumberDockSide.Right)
							zNewLocation.X = zParent.Right + 1;
						zNewLocation.Y = zParent.Top;
						this.Location = zNewLocation;
						this.Size = zNewSize;

						//break;
				} else if (zDockSide == LineNumberDockSide.None) {
					// --- DockSide = None, but AutoSizing is still setting the Width
					//case zDockSide == LineNumberDockSide.None:
						if (zAutoSizing_Size.Width > 0)
							zNewSize.Width = zAutoSizing_Size.Width;
						this.Size = zNewSize;

						//break;
				}

			} else {
				// --- No AutoSizing
				//switch (true) {
				if (zParent == null){
					//case zParent == null:
						// --- ReminderMessage sizing
						if (zAutoSizing_Size.Width > 0)
							zNewSize.Width = zAutoSizing_Size.Width;
						if (zAutoSizing_Size.Height > 0)
							zNewSize.Height = zAutoSizing_Size.Height;
						this.Size = zNewSize;

						//break;
				}else if (zDockSide != LineNumberDockSide.None){
					// --- No AutoSizing, but DockSide L/R/H is active so height and position need updates.
					//case zDockSide != LineNumberDockSide.None:
						zNewSize.Height = zParent.Height;
						if (zDockSide == LineNumberDockSide.Left)
							zNewLocation.X = zParent.Left - zNewSize.Width - 1;
						if (zDockSide == LineNumberDockSide.Right)
							zNewLocation.X = zParent.Right + 1;
						zNewLocation.Y = zParent.Top;
						this.Location = zNewLocation;
						this.Size = zNewSize;

						//break;
				}
			}

		}


		/// <summary>
		/// This Sub determines which textlines are visible in the ParentRichTextBox, and makes LineNumberItems (LineNumber + ItemRectangle)
		/// for each visible line. They are put into the zLNIs List that will be used by the OnPaint event to draw the LineNumberItems. 
		/// </summary>
		/// <remarks></remarks>
		private void Update_VisibleLineNumberItems()
		{
            // ################
            int tmpY;
			// ###############
			zLNIs.Clear();
			zAutoSizing_Size = new Size(0, 0);
			zLineNumbers_Format = "0";
			//initial setting
			//   To measure the LineNumber's width, its Format 0 is replaced by w as that is likely to be one of the widest characters in non-monospace fonts. 
			if (zAutoSizing == true)
				zAutoSizing_Size = new Size(TextRenderer.MeasureText(zLineNumbers_Format.Replace('0', 'W'), this.Font).Width, 0);
				//zAutoSizing_Size = new Size(TextRenderer.MeasureText(zLineNumbers_Format.Replace("0".ToCharArray(), "W".ToCharArray()), this.Font).Width, 0);

			if (zParent == null || string.IsNullOrEmpty(zParent.Text))
				return;

			// --- Make sure the LineNumbers are aligning to the same height as the zParent textlines by converting to screencoordinates
			//   and using that as an offset that gets added to the points for the LineNumberItems
			zPointInParent = zParent.PointToScreen(zParent.ClientRectangle.Location);
			zPointInMe = this.PointToScreen(new Point(0, 0));
			//   zParentInMe is the vertical offset to make the LineNumberItems line up with the textlines in zParent.
			zParentInMe = zPointInParent.Y - zPointInMe.Y + 1;
			//   The first visible LineNumber may not be the first visible line of text in the RTB if the LineNumbercontrol's .Top is lower on the form than
			//   the .Top of the parent RichTextBox. Therefor, zPointInParent will now be used to find zPointInMe's equivalent height in zParent, 
			//   which is needed to find the best StartIndex later on.
			zPointInParent = zParent.PointToClient(zPointInMe);

			// --- NOTES: 
			//   Additional complication is the fact that when wordwrap is enabled on the RTB, the wordwrapped text spills into the RTB.Lines collection, 
			//   so we need to split the text into lines ourselves, and use the Index of each zSplit-line's first character instead of the RTB's.
			string[] zSplit = zParent.Text.Split(Constants.vbCrLf.ToCharArray());

			if (zSplit.Length < 2) {
				//   Just one line in the text = one linenumber
				//   NOTE:  zContentRectangle is built by the zParent.ContentsResized event.
				Point zPoint = zParent.GetPositionFromCharIndex(0);
				zLNIs.Add(new LineNumberItem(1, new Rectangle(new Point(0, zPoint.Y - 1 + zParentInMe), new Size(this.Width, zContentRectangle.Height - zPoint.Y))));


			} else {
				//   Multiple lines, but store only those LineNumberItems for lines that are visible.
				TimeSpan zTimeSpan = new TimeSpan(DateAndTime.Now.Ticks);
				Point zPoint = new Point(0, 0);
				int zStartIndex = 0;
				int zSplitStartLine = 0;
				int zA = zParent.Text.Length - 1;
				// #########################
					
					//this.FindStartIndex(ref zStartIndex, ref zA, ref zPointInParent.Y);
					tmpY = zPointInParent.Y;
					this.FindStartIndex(ref zStartIndex, ref zA, ref tmpY);
					zPointInParent.Y = tmpY;

				// ################


				//   zStartIndex now holds the index of a character in the first visible line from zParent.Text
				//   Now it will be pointed at the first character of that line (chr(10) = Linefeed part of the vbCrLf constant)
				zStartIndex = Math.Max(0, Math.Min(zParent.Text.Length - 1, zParent.Text.Substring(0, zStartIndex).LastIndexOf(Strings.Chr(10)) + 1));

				//   We now need to find out which zSplit-line that character is in, by counting the vbCrlf appearances that come before it.
				zSplitStartLine = Math.Max(0, zParent.Text.Substring(0, zStartIndex).Split(Constants.vbCrLf.ToCharArray()).Length - 1);

				//   zStartIndex starts off pointing at the first character of the first visible line, and will be then be pointed to 
				//   the index of the first character on the next line.
				for (zA = zSplitStartLine; zA <= zSplit.Length - 1; zA++) {
					zPoint = zParent.GetPositionFromCharIndex(zStartIndex);
					zStartIndex += Math.Max(1, zSplit[zA].Length + 1);
					if (zPoint.Y + zParentInMe > this.Height)
						break; // TODO: might not be correct. Was : Exit For
					//   For performance reasons, the list of LineNumberItems (zLNIs) is first built with only the location of its 
					//   itemrectangle being used. The height of those rectangles will be computed afterwards by comparing the items' Y coordinates.
					zLNIs.Add(new LineNumberItem(zA + 1, new Rectangle(0, zPoint.Y - 1 + zParentInMe, this.Width, 1)));
					if (zParentIsScrolling == true && DateAndTime.Now.Ticks > zTimeSpan.Ticks + 500000) {
						//   The more lines there are in the RTB, the slower the RTB's .GetPositionFromCharIndex() method becomes
						//   To avoid those delays from interfering with the scrollingspeed, this speedbased exit for is applied (0.05 sec)
						//   zLNIs will have at least 1 item, and if that's the only one, then change its location to 0,0 to make it readable
						if (zLNIs.Count == 1)
							zLNIs[0].Rectangle.Y = 0;
							// zLNIs(0).Rectangle.Y = 0;

						zParentIsScrolling = false;
						zTimer.Start();
						break; // TODO: might not be correct. Was : Exit For
					}
				}

				if (zLNIs.Count == 0)
					return;

				//   Add an extra placeholder item to the end, to make the heightcomputation easier
				if (zA < zSplit.Length) {
					//   getting here means the for/next loop was exited before reaching the last zSplit textline
					//   zStartIndex will still be pointing to the startcharacter of the next line, so we can use that:
					zPoint = zParent.GetPositionFromCharIndex(Math.Min(zStartIndex, zParent.Text.Length - 1));
					zLNIs.Add(new LineNumberItem(-1, new Rectangle(0, zPoint.Y - 1 + zParentInMe, 0, 0)));
				} else {
					//   getting here means the for/next loop ran to the end (zA is now zSplit.Length). 
					zLNIs.Add(new LineNumberItem(-1, new Rectangle(0, zContentRectangle.Bottom, 0, 0)));
				}

				//   And now we can easily compute the height of the LineNumberItems by comparing each item's Y coordinate with that of the next line.
				//   There's at least two items in the list, and the last item is a "nextline-placeholder" that will be removed.
				for (zA = 0; zA <= zLNIs.Count - 2; zA++) {
					zLNIs[zA].Rectangle.Height = Math.Max(1, zLNIs[zA + 1].Rectangle.Y - zLNIs[zA].Rectangle.Y);
					//zLNIs(zA).Rectangle.Height = Math.Max(1, zLNIs(zA + 1).Rectangle.Y - zLNIs(zA).Rectangle.Y);
				}
				//   Removing the placeholder item
				zLNIs.RemoveAt(zLNIs.Count - 1);

				// Set the Format to the width of the highest possible number so that LeadingZeroes shows the correct amount of zeroes.
				if (zLineNumbers_ShowAsHexadecimal == true) {
					//zLineNumbers_Format = "".PadRight(zSplit.Length.ToString("X").Length, "0");
					zLineNumbers_Format = "".PadRight(zSplit.Length.ToString("X").Length, '0');
				} else {
					//zLineNumbers_Format = "".PadRight(zSplit.Length.ToString().Length, "0");
					zLineNumbers_Format = "".PadRight(zSplit.Length.ToString().Length, '0');
				}
			}

			//   To measure the LineNumber's width, its Format 0 is replaced by w as that is likely to be one of the widest characters in non-monospace fonts. 
			if (zAutoSizing == true)
				zAutoSizing_Size = new Size(TextRenderer.MeasureText(zLineNumbers_Format.Replace('0', 'W'), this.Font).Width, 0);
            //zAutoSizing_Size = new Size(TextRenderer.MeasureText(zLineNumbers_Format.Replace("0".ToCharArray(), "W".ToCharArray()), this.Font).Width, 0);
		}

		/// <summary>
		/// FindStartIndex is a recursive Sub (one that calls itself) to compute the first visible line that should have a LineNumber.
		/// </summary>
		/// <param name="zMin"> this will hold the eventual BestStartIndex when the Sub has completed its run.</param>
		/// <param name="zMax"></param>
		/// <param name="zTarget"></param>
		/// <remarks></remarks>
		private void FindStartIndex(ref int zMin, ref int zMax, ref int zTarget)
		{
			//   Recursive Sub to compute best starting index - only run when zParent is known to exist
			if (zMax == zMin + 1 | zMin == (zMax + zMin) / 2)
				return;

			if(zParent.GetPositionFromCharIndex((zMax + zMin) / 2).Y == zTarget){
				//switch (zParent.GetPositionFromCharIndex((zMax + zMin) / 2).Y) {
				//	case  // ERROR: Case labels with binary operators are unsupported : Equality
				//   BestStartIndex found
				zMin = (zMax + zMin) / 2;
				//break;
			}
			else if (zParent.GetPositionFromCharIndex((zMax + zMin) / 2).Y > zTarget)
			{
				//case  // ERROR: Case labels with binary operators are unsupported : GreaterThan
				//zTarget:
				//   Look again, in lower half
				zMax = (zMax + zMin) / 2;
				FindStartIndex(ref zMin, ref zMax, ref zTarget);
				//break;
			}
			else if (zParent.GetPositionFromCharIndex((zMax + zMin) / 2).Y < 0)
			{
				// case  // ERROR: Case labels with binary operators are unsupported : LessThan
				//0:
				//   Look again, in top half
				zMin = (zMax + zMin) / 2;
				FindStartIndex(ref zMin, ref zMax, ref zTarget);
				//break;
			}

		}


		/// <summary>
		/// OnPaint will go through the enabled elements (vertical ReminderMessage, GridLines, LineNumbers, BorderLines, MarginLines) and will
		/// draw them if enabled. At the same time, it will build GraphicsPaths for each of those elements (that are enabled), which will be used 
		/// in SeeThroughMode (if it's active): the figures in the GraphicsPaths will form a customized outline for the control by setting them as the 
		/// Region of the LineNumber control. Note: the vertical ReminderMessages are only drawn during designtime. 
		/// </summary>
		/// <param name="e"></param>
		/// <remarks></remarks>
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			//   Build the list of visible LineNumberItems (= zLNIs) first. (doesn't take long, so it can stay in OnPaint)
			this.Update_VisibleLineNumberItems();
			base.OnPaint(e);

			// --- QualitySettings
			if (zLineNumbers_AntiAlias == true) {
				e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			} else {
				e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			}

			// --- Local Declarations
			string zTextToShow = "";
			string zReminderToShow = "";
			StringFormat zSF = new StringFormat();
			SizeF zTextSize = default(SizeF);
			Pen zPen = new Pen(this.ForeColor);
			SolidBrush zBrush = new SolidBrush(this.ForeColor);
			Point zPoint = new Point(0, 0);
			Rectangle zItemClipRectangle = new Rectangle(0, 0, 0, 0);

			//   NOTE: The GraphicsPaths are only used for SeeThroughMode
			//   FillMode.Winding: combined outline ( Alternate: XOR'ed outline )
			System.Drawing.Drawing2D.GraphicsPath zGP_GridLines = new System.Drawing.Drawing2D.GraphicsPath(System.Drawing.Drawing2D.FillMode.Winding);
			System.Drawing.Drawing2D.GraphicsPath zGP_BorderLines = new System.Drawing.Drawing2D.GraphicsPath(System.Drawing.Drawing2D.FillMode.Winding);
			System.Drawing.Drawing2D.GraphicsPath zGP_MarginLines = new System.Drawing.Drawing2D.GraphicsPath(System.Drawing.Drawing2D.FillMode.Winding);
			System.Drawing.Drawing2D.GraphicsPath zGP_LineNumbers = new System.Drawing.Drawing2D.GraphicsPath(System.Drawing.Drawing2D.FillMode.Winding);
			Region zRegion = new Region(base.ClientRectangle);


			// ----------------------------------------------
			// --- DESIGNTIME / NO VISIBLE ITEMS
			if (this.DesignMode == true) {
				//   Show a vertical reminder message
				if (zParent == null) {
					zReminderToShow = "-!- Set ParentRichTextBox -!-";
				} else {
					if (zLNIs.Count == 0)
						zReminderToShow = "LineNrs (  " + zParent.Name + "  )";
				}
				if (zReminderToShow.Length > 0) {
					// --- Centering and Rotation for the reminder message
					e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
					e.Graphics.RotateTransform(-90);
					zSF.Alignment = StringAlignment.Center;
					zSF.LineAlignment = StringAlignment.Center;
					// --- Show the reminder message (with small shadow)
					zTextSize = e.Graphics.MeasureString(zReminderToShow, this.Font, zPoint, zSF);
					e.Graphics.DrawString(zReminderToShow, this.Font, Brushes.WhiteSmoke, 1, 1, zSF);
					e.Graphics.DrawString(zReminderToShow, this.Font, Brushes.Firebrick, 0, 0, zSF);
					e.Graphics.ResetTransform();

					//Rectangle zReminderRectangle = new Rectangle(this.Width / 2 - zTextSize.Height / 2, this.Height / 2 - zTextSize.Width / 2, zTextSize.Height, zTextSize.Width);
					Rectangle zReminderRectangle = new Rectangle((int)(this.Width / 2 - zTextSize.Height / 2), (int)(this.Height / 2 - zTextSize.Width / 2), (int)(zTextSize.Height), (int)(zTextSize.Width));
					zGP_LineNumbers.AddRectangle(zReminderRectangle);
					zGP_LineNumbers.CloseFigure();

					if (zAutoSizing == true) {
						zReminderRectangle.Inflate((int)(zTextSize.Height * 0.2), (int)(zTextSize.Width * 0.1));
						//zReminderRectangle.Inflate(zTextSize.Height * 0.2, zTextSize.Width * 0.1);
						zAutoSizing_Size = new Size(zReminderRectangle.Width, zReminderRectangle.Height);
					}
				}
			}


			// ----------------------------------------------
			// --- DESIGN OR RUNTIME / WITH VISIBLE ITEMS (which means zParent exists)
			if (zLNIs.Count > 0) {
				//   The visible LineNumberItems with their BackgroundGradient and GridLines
				//   Loop through every visible LineNumberItem
				System.Drawing.Drawing2D.LinearGradientBrush zLGB = null;
				zPen = new Pen(zGridLines_Color, zGridLines_Thickness);
				zPen.DashStyle = zGridLines_Style;
				zSF.Alignment = StringAlignment.Near;
				zSF.LineAlignment = StringAlignment.Near;
				//zSF.FormatFlags = StringFormatFlags.FitBlackBox + StringFormatFlags.NoClip + StringFormatFlags.NoWrap;
				zSF.FormatFlags = StringFormatFlags.FitBlackBox | StringFormatFlags.NoClip | StringFormatFlags.NoWrap;


				for (int zA = 0; zA <= zLNIs.Count - 1; zA++) {
					// --- BackgroundGradient
					if (zGradient_Show == true) {
						//zLGB = new Drawing2D.LinearGradientBrush(zLNIs(zA).Rectangle, zGradient_StartColor, zGradient_EndColor, zGradient_Direction);
						zLGB = new System.Drawing.Drawing2D.LinearGradientBrush(zLNIs[zA].Rectangle, zGradient_StartColor, zGradient_EndColor, zGradient_Direction);
						e.Graphics.FillRectangle(zLGB, zLNIs[zA].Rectangle);
						//e.Graphics.FillRectangle(zLGB, zLNIs(zA).Rectangle);
					}

					// --- GridLines
					if (zGridLines_Show == true) {
						e.Graphics.DrawLine(zPen, new Point(0, zLNIs[zA].Rectangle.Y), new Point(this.Width, zLNIs[zA].Rectangle.Y));
						//e.Graphics.DrawLine(zPen, new Point(0, zLNIs(zA).Rectangle.Y), new Point(this.Width, zLNIs(zA).Rectangle.Y));

						//   NOTE: Every item in a GraphicsPath is a closed figure, so instead of adding gridlines as lines, we'll add them
						//   as rectangles that loop out of sight. Their height uses the zContentRectangle which is the maxsize of 
						//   the ParentRichTextBox's contents. 
						//   NOTE: Slight adjustment needed when the first item has a negative Y coordinate. 
						//   This explains the " - zLNIs(0).Rectangle.Y" (which adds the negative size to the height 
						//   to make sure the rectangle's bottompart stays out of sight) 
						//zGP_GridLines.AddRectangle(new Rectangle(-zGridLines_Thickness, zLNIs(zA).Rectangle.Y, this.Width + zGridLines_Thickness * 2, this.Height - zLNIs(0).Rectangle.Y + zGridLines_Thickness));
						zGP_GridLines.AddRectangle(new Rectangle(	(int)(-zGridLines_Thickness),
																											(int)(zLNIs[zA].Rectangle.Y),
																											(int)(this.Width + zGridLines_Thickness * 2),
																											(int)(this.Height - zLNIs[zA].Rectangle.Y + zGridLines_Thickness)
																											));
						zGP_GridLines.CloseFigure();
					}

					// --- LineNumbers
					if (zLineNumbers_Show == true) {
						//   TextFormatting
						if (zLineNumbers_ShowLeadingZeroes == true) {
							zTextToShow = (zLineNumbers_ShowAsHexadecimal ? zLNIs[zA].LineNumber.ToString("X") : zLNIs[zA].LineNumber.ToString(zLineNumbers_Format));
							//zTextToShow = (zLineNumbers_ShowAsHexadecimal ? zLNIs(zA).LineNumber.ToString("X") : zLNIs(zA).LineNumber.ToString(zLineNumbers_Format));
						} else {
							zTextToShow = (zLineNumbers_ShowAsHexadecimal ? zLNIs[zA].LineNumber.ToString("X") : zLNIs[zA].LineNumber.ToString());
							//zTextToShow = (zLineNumbers_ShowAsHexadecimal ? zLNIs(zA).LineNumber.ToString("X") : zLNIs(zA).LineNumber.ToString);
						}

						//   TextSizing
						zTextSize = e.Graphics.MeasureString(zTextToShow, this.Font, zPoint, zSF);
						//   TextAlignment and positioning   (zPoint = TopLeftCornerPoint of the text)
						//   TextAlignment, padding, manual offset (via LineNrs_Offset) and zTextSize are all included in the calculation of zPoint. 
						switch (zLineNumbers_Alignment) {
							case ContentAlignment.TopLeft:
								zPoint = new Point((int)(zLNIs[zA].Rectangle.Left + this.Padding.Left + zLineNumbers_Offset.Width), (int)(zLNIs[zA].Rectangle.Top + this.Padding.Top + zLineNumbers_Offset.Height));
								break;
							case ContentAlignment.MiddleLeft:
								zPoint = new Point((int)(zLNIs[zA].Rectangle.Left + this.Padding.Left + zLineNumbers_Offset.Width), (int)(zLNIs[zA].Rectangle.Top + (zLNIs[zA].Rectangle.Height / 2) + zLineNumbers_Offset.Height - zTextSize.Height / 2));
								break;
							case ContentAlignment.BottomLeft:
								zPoint = new Point((int)(zLNIs[zA].Rectangle.Left + this.Padding.Left + zLineNumbers_Offset.Width), (int)(zLNIs[zA].Rectangle.Bottom - this.Padding.Bottom + 1 + zLineNumbers_Offset.Height - zTextSize.Height));
								break;
							case ContentAlignment.TopCenter:
								zPoint = new Point((int)(zLNIs[zA].Rectangle.Width / 2 + zLineNumbers_Offset.Width - zTextSize.Width / 2), (int)(zLNIs[zA].Rectangle.Top + this.Padding.Top + zLineNumbers_Offset.Height));
								break;
							case ContentAlignment.MiddleCenter:
								zPoint = new Point((int)(zLNIs[zA].Rectangle.Width / 2 + zLineNumbers_Offset.Width - zTextSize.Width / 2), (int)(zLNIs[zA].Rectangle.Top + (zLNIs[zA].Rectangle.Height / 2) + zLineNumbers_Offset.Height - zTextSize.Height / 2));
								break;
							case ContentAlignment.BottomCenter:
								zPoint = new Point((int)(zLNIs[zA].Rectangle.Width / 2 + zLineNumbers_Offset.Width - zTextSize.Width / 2), (int)(zLNIs[zA].Rectangle.Bottom - this.Padding.Bottom + 1 + zLineNumbers_Offset.Height - zTextSize.Height));
								break;
							case ContentAlignment.TopRight:
								zPoint = new Point((int)(zLNIs[zA].Rectangle.Right - this.Padding.Right + zLineNumbers_Offset.Width - zTextSize.Width), (int)(zLNIs[zA].Rectangle.Top + this.Padding.Top + zLineNumbers_Offset.Height));
								break;
							case ContentAlignment.MiddleRight:
								zPoint = new Point((int)(zLNIs[zA].Rectangle.Right - this.Padding.Right + zLineNumbers_Offset.Width - zTextSize.Width), (int)(zLNIs[zA].Rectangle.Top + (zLNIs[zA].Rectangle.Height / 2) + zLineNumbers_Offset.Height - zTextSize.Height / 2));
								break;
							case ContentAlignment.BottomRight:
								zPoint = new Point((int)(zLNIs[zA].Rectangle.Right - this.Padding.Right + zLineNumbers_Offset.Width - zTextSize.Width), (int)(zLNIs[zA].Rectangle.Bottom - this.Padding.Bottom + 1 + zLineNumbers_Offset.Height - zTextSize.Height));
								break;
						}
						//   TextClipping
						zItemClipRectangle = new Rectangle(zPoint, zTextSize.ToSize());
						if (zLineNumbers_ClipByItemRectangle == true) {
							//   If selected, the text will be clipped so that it doesn't spill out of its own LineNumberItem-area.
							//   Only the part of the text inside the LineNumberItem.Rectangle should be visible, so intersect with the ItemRectangle
							//   The SetClip method temporary restricts the drawing area of the control for whatever is drawn next.
							zItemClipRectangle.Intersect(zLNIs[zA].Rectangle);
							e.Graphics.SetClip(zItemClipRectangle);
						}
						//   TextDrawing
						e.Graphics.DrawString(zTextToShow, this.Font, zBrush, zPoint, zSF);
						e.Graphics.ResetClip();
						//   The GraphicsPath for the LineNumber is just a rectangle behind the text, to keep the paintingspeed high and avoid ugly artifacts.
						zGP_LineNumbers.AddRectangle(zItemClipRectangle);
						zGP_LineNumbers.CloseFigure();
					}
				}

				// --- GridLinesThickness and Linestyle in SeeThroughMode. All GraphicsPath lines are drawn as solid to keep the paintingspeed high.
				if (zGridLines_Show == true) {
					zPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
					zGP_GridLines.Widen(zPen);
				}

				// --- Memory CleanUp
				if (zLGB != null)
					zLGB.Dispose();
			}


			// ----------------------------------------------
			// --- DESIGN OR RUNTIME / ALWAYS
			//Point zP_Left = new Point(Math.Floor(zBorderLines_Thickness / 2), Math.Floor(zBorderLines_Thickness / 2));
			//Point zP_Right = new Point(this.Width - Math.Ceiling(zBorderLines_Thickness / 2), this.Height - Math.Ceiling(zBorderLines_Thickness / 2));

			Point zP_Left = new Point(
																	(int)(Math.Floor(zBorderLines_Thickness / 2)),
																	(int)(Math.Floor(zBorderLines_Thickness / 2))
															 );
			Point zP_Right = new Point(
																	(int)(this.Width - Math.Ceiling(zBorderLines_Thickness / 2)),
																	(int)(this.Height - Math.Ceiling(zBorderLines_Thickness / 2))
																);

			// --- BorderLines 
			Point[] zBorderLines_Points = {
				new Point(zP_Left.X, zP_Left.Y),
				new Point(zP_Right.X, zP_Left.Y),
				new Point(zP_Right.X, zP_Right.Y),
				new Point(zP_Left.X, zP_Right.Y),
				new Point(zP_Left.X, zP_Left.Y)
			};
			if (zBorderLines_Show == true) {
				zPen = new Pen(zBorderLines_Color, zBorderLines_Thickness);
				zPen.DashStyle = zBorderLines_Style;
				e.Graphics.DrawLines(zPen, zBorderLines_Points);
				zGP_BorderLines.AddLines(zBorderLines_Points);
				zGP_BorderLines.CloseFigure();
				//   BorderThickness and Style for SeeThroughMode
				zPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
				zGP_BorderLines.Widen(zPen);
			}


			// --- MarginLines 
			if (zMarginLines_Show == true && zMarginLines_Side > LineNumberDockSide.None) {
				zP_Left = new Point((int)(-zMarginLines_Thickness), (int)(-zMarginLines_Thickness));
				zP_Right = new Point((int)(this.Width + zMarginLines_Thickness), (int)(this.Height + zMarginLines_Thickness));
				zPen = new Pen(zMarginLines_Color, zMarginLines_Thickness);
				zPen.DashStyle = zMarginLines_Style;
				if (zMarginLines_Side == LineNumberDockSide.Left | zMarginLines_Side == LineNumberDockSide.Height) {
					e.Graphics.DrawLine(zPen, new Point(
																							(int)(Math.Floor(zMarginLines_Thickness / 2)), 0),
																							new Point(
																												(int)(Math.Floor(zMarginLines_Thickness / 2)),
																												this.Height - 1)
																												);
					zP_Left = new Point(
															(int)(Math.Ceiling(zMarginLines_Thickness / 2)),
															(int)(-zMarginLines_Thickness));
				}
				if (zMarginLines_Side == LineNumberDockSide.Right | zMarginLines_Side == LineNumberDockSide.Height) {
					e.Graphics.DrawLine(zPen, new Point(
																							(int)(this.Width - Math.Ceiling(zMarginLines_Thickness / 2)), 0),
																							new Point(
																												(int)(this.Width - Math.Ceiling(zMarginLines_Thickness / 2)),
																												(int)(this.Height - 1))
																						);

					zP_Right = new Point(
																(int)(this.Width - Math.Ceiling(zMarginLines_Thickness / 2)),
																(int)(this.Height + zMarginLines_Thickness)
															);
				}
				//   GraphicsPath for the MarginLines(s):
				//   MarginLines(s) are drawn as a rectangle connecting the zP_Left and zP_Right points, which are either inside or 
				//   outside of sight, depending on whether the MarginLines at that side is visible. zP_Left: TopLeft and ZP_Right: BottomRight
				zGP_MarginLines.AddRectangle(new Rectangle(zP_Left, new Size(zP_Right.X - zP_Left.X, zP_Right.Y - zP_Left.Y)));
				zPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
				zGP_MarginLines.Widen(zPen);
			}


			// ----------------------------------------------
			// --- SeeThroughMode
			//   combine all the GraphicsPaths (= zGP_... ) and set them as the region for the control.
			if (zSeeThroughMode == true) {
				zRegion.MakeEmpty();
				zRegion.Union(zGP_BorderLines);
				zRegion.Union(zGP_MarginLines);
				zRegion.Union(zGP_GridLines);
				zRegion.Union(zGP_LineNumbers);
			}

			// --- Region
			if (zRegion.GetBounds(e.Graphics).IsEmpty == true) {
				//   Note: If the control is in a condition that would show it as empty, then a border-region is still drawn regardless of it's borders on/off state.
				//   This is added to make sure that the bounds of the control are never lost (it would remain empty if this was not done).
				zGP_BorderLines.AddLines(zBorderLines_Points);
				zGP_BorderLines.CloseFigure();
				zPen = new Pen(zBorderLines_Color, 1);
				zPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
				zGP_BorderLines.Widen(zPen);

				zRegion = new Region(zGP_BorderLines);
			}
			this.Region = zRegion;


			// ----------------------------------------------
			// --- Memory CleanUp
			if (zPen != null)
				zPen.Dispose();
			if (zBrush != null)
				zPen.Dispose();
			if (zRegion != null)
				zRegion.Dispose();
			if (zGP_GridLines != null)
				zGP_GridLines.Dispose();
			if (zGP_BorderLines != null)
				zGP_BorderLines.Dispose();
			if (zGP_MarginLines != null)
				zGP_MarginLines.Dispose();
			if (zGP_LineNumbers != null)
				zGP_LineNumbers.Dispose();

		}


		////////////////////////////////////////////////////////////////////////////////////////////////////

		private void zTimer_Tick(object sender, System.EventArgs e)
		{
            zParentIsScrolling = false;
			zTimer.Stop();
			this.Invalidate();
		}

		private void zParent_Changed(object sender, System.EventArgs e)
		{
			this.Refresh();
			this.Invalidate();
		}

		private void zParent_Scroll(object sender, System.EventArgs e)
		{
			zParentIsScrolling = true;
			this.Invalidate();
            this.Refresh();
        }

		private void zParent_ContentsResized(object sender, System.Windows.Forms.ContentsResizedEventArgs e)
		{
			zContentRectangle = e.NewRectangle;
			this.Refresh();
			this.Invalidate();
		}

		private void zParent_Disposed(object sender, System.EventArgs e)
		{
			this.ParentRichTextBox = null;
			this.Refresh();
			this.Invalidate();
		}

	}
}
