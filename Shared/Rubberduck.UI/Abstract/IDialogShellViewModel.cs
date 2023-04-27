using System.Drawing;

namespace Rubberduck.UI.Abstract
{
    public interface IDialogShellViewModel
    {
        string TitleText { get; set; }
        Image IconSource { get; set; }
        string TitleLabelText { get; set; }
        string InstructionsLabelText { get; set; }
        string ContentsText { get; set; }
        string OptionLabelText { get; set; }
        bool OptionIsChecked { get; set; }
        string CancelButtonText { get; set; }
        string DefaultButtonText { get; set; }
        //Whether or not to display the OptionLabel and bind OptionLabelText
        bool HasOption { get; set; }
        //Whether or not to display the CancelButton and bind CancelButtonText
        bool HasCancelButton { get; set; }
        //Whether or not to include minimize/maximize buttons in the control box, and whether the user can drag the border of the control to resize it
        bool CanResize { get; set; }
        //Ensures a minimum breathing space for the client area when[re]sizing.
        int ClientAreaMinHeight { get; set; }
    }
}
