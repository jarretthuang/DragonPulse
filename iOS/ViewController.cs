using System;
using DragonPulse.Models;
using Foundation;
using UIKit;

namespace DragonPulse.iOS
{
    public partial class ViewController : UIViewController
    {
        static string characterNameNullText = "Character Name...";

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        partial void SearchButton_TouchUpInside(UIButton sender)
        {
            charNameTextField.ResignFirstResponder();
            var charName = charNameTextField.Text;
            var url = "http://na-bns.ncsoft.com/ingame/bs/character/profile?c=" + charName.Trim().Replace(" ", "%20");
            var scraper = new WebScraper()
            {
                Url = url
            };
            testTextView.Text = scraper.ScrapeHongmoonLevel();
            profilePicView.Image = UIImageFromUrl(scraper.ScrapeProfilePicUrl());
        }


        private static UIImage UIImageFromUrl(string uri)
        {
            using (var url = new NSUrl(uri))
            using (var data = NSData.FromUrl(url))
                return UIImage.LoadFromData(data);
        }

        partial void ClearCharacterNameText(UITextField sender)
        {
            if (sender.Text == characterNameNullText) sender.Text = string.Empty;
            sender.PerformSelector(new ObjCRuntime.Selector("selectAll"), null, 0.0f);
        }
    }
}
