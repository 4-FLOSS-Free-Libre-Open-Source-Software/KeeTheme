using System.Drawing;
using System.Windows.Forms;
using DarkTheme.Custom;

namespace DarkTheme
{
	internal interface ISkin
	{
		TreeViewDrawMode TreeViewDrawMode { get; }
		Image ListViewBackground { get; }
		bool ListViewBackgroundTiled { get; }
		ToolStripRenderer ToolStripRenderer { get; }

		OtherLook Other { get; }
		ControlLook Control { get; }
		ControlLook Form { get; }
		ButtonLook Button { get; }
		TreeViewLook TreeView { get; }
		RichTextBoxLook RichTextBox { get; }
		LinkLabelLook LinkLabel { get; }
		ListViewLook ListView { get; }
		ControlLook SecureTextBox { get; }
	}
}