using System;
using CoreGraphics;
using UIKit;

namespace StrapButtonSharp
{
    public static class UIButtonExtension
    {
        public static void AddAwesomeIcon(this UIButton self, AwesomeIcon icon, bool befor)
        {
            /* NSString *iconString = [NSString stringFromAwesomeIcon:icon];
                self.titleLabel.font = [UIFont fontWithName:@"FontAwesome"
                                                       size:self.titleLabel.font.pointSize];
    
                NSString *title = [NSString stringWithFormat:@"%@", iconString];
    
                if(self.titleLabel.text) {
                    if(before)
                        title = [title stringByAppendingFormat:@" %@", self.titleLabel.text];
                    else
                        title = [NSString stringWithFormat:@"%@  %@", self.titleLabel.text, iconString];
                }
    
                [self setTitle:title forState:UIControlStateNormal];
             */
            var iconString = StringFromAwesomeIcon(icon);
            self.TitleLabel.Font = UIFont.FromName("FontAwesome", self.TitleLabel.Font.PointSize);
            var title = String.Empty;
            if (befor)
            {
                title = iconString + " " + self.TitleLabel.Text;
            }
            else
            { 
                title = self.TitleLabel.Text + " " + iconString;
            }
            self.SetTitle(title, UIControlState.Normal);
        }

        public static void BootstrapStyle(this UIButton self)
        {
            //self.layer.borderWidth = 1;
            //self.layer.cornerRadius = 4.0;
            //self.layer.masksToBounds = YES;
            //[self setAdjustsImageWhenHighlighted:NO];
            //[self setTitleColor:[UIColor whiteColor] forState:UIControlStateNormal];
            //[self.titleLabel setFont:[UIFont fontWithName:@"FontAwesome" size:self.titleLabel.font.pointSize]];
            self.Layer.BorderWidth = 1;
            self.Layer.CornerRadius = 4f;
            self.Layer.MasksToBounds = true;
            self.AdjustsImageWhenHighlighted = false;
            self.SetTitleColor(UIColor.White, UIControlState.Normal);
            self.TitleLabel.Font = UIFont.FromName(@"FontAwesome", self.TitleLabel.Font.PointSize);
        }

        public static void DefaultStyle(this UIButton self)
        {
            /*
            [self bootstrapStyle];
            [self setTitleColor:[UIColor blackColor] forState:UIControlStateNormal];
            [self setTitleColor:[UIColor blackColor] forState:UIControlStateHighlighted];
            self.backgroundColor = [UIColor whiteColor];
            self.layer.borderColor = [[UIColor colorWithRed:204/255.0 green:204/255.0 blue:204/255.0 alpha:1] CGColor];
            [self setBackgroundImage:[self buttonImageFromColor:[UIColor colorWithRed:235/255.0 green:235/255.0 blue:235/255.0 alpha:1]] forState:UIControlStateHighlighted];
             */

            self.BootstrapStyle();
            self.SetTitleColor(UIColor.Black, UIControlState.Normal);
            self.SetTitleColor(UIColor.Black, UIControlState.Highlighted);
            self.BackgroundColor = UIColor.White;
            self.Layer.BorderColor = UIColor.FromRGB(204, 204, 204).CGColor;
            self.SetBackgroundImage(self.ImageFromColor(UIColor.FromRGB(235, 235, 235)), UIControlState.Highlighted);
        }

        public static void PrimaryStyle(this UIButton self)
        {
            /*  [self bootstrapStyle];
                self.backgroundColor = [UIColor colorWithRed:66/255.0 green:139/255.0 blue:202/255.0 alpha:1];
                self.layer.borderColor = [[UIColor colorWithRed:53/255.0 green:126/255.0 blue:189/255.0 alpha:1] CGColor];
                [self setBackgroundImage:[self buttonImageFromColor:[UIColor colorWithRed:51/255.0 green:119/255.0 blue:172/255.0 alpha:1]] forState:UIControlStateHighlighted];
             */
            self.BootstrapStyle();
            self.BackgroundColor = UIColor.FromRGB(66, 139, 202);
            self.Layer.BorderColor = UIColor.FromRGB(53, 126, 189).CGColor;
            self.SetBackgroundImage(self.ImageFromColor(UIColor.FromRGB(51, 119, 172)), UIControlState.Highlighted);
        }

        public static void SuccessStyle(this UIButton self)
        {
            /*
             *  [self bootstrapStyle];
                self.backgroundColor = [UIColor colorWithRed:92/255.0 green:184/255.0 blue:92/255.0 alpha:1];
                self.layer.borderColor = [[UIColor colorWithRed:76/255.0 green:174/255.0 blue:76/255.0 alpha:1] CGColor];
                [self setBackgroundImage:[self buttonImageFromColor:[UIColor colorWithRed:69/255.0 green:164/255.0 blue:84/255.0 alpha:1]] forState:UIControlStateHighlighted];
             */
            self.BootstrapStyle();
            self.BackgroundColor = UIColor.FromRGB(92, 184, 92);
            self.Layer.BorderColor = UIColor.FromRGB(76, 174, 76).CGColor;
            self.SetBackgroundImage(self.ImageFromColor(UIColor.FromRGB(69, 164, 84)), UIControlState.Highlighted);
        }

        public static void InfoStyle(this UIButton self)
        {
            /* [self bootstrapStyle];
                self.backgroundColor = [UIColor colorWithRed:91/255.0 green:192/255.0 blue:222/255.0 alpha:1];
                self.layer.borderColor = [[UIColor colorWithRed:70/255.0 green:184/255.0 blue:218/255.0 alpha:1] CGColor];
                [self setBackgroundImage:[self buttonImageFromColor:[UIColor colorWithRed:57/255.0 green:180/255.0 blue:211/255.0 alpha:1]] forState:UIControlStateHighlighted];
             */
            self.BootstrapStyle();
            self.BackgroundColor = UIColor.FromRGB(91, 192, 222);
            self.Layer.BorderColor = UIColor.FromRGB(70, 184, 218).CGColor;
            self.SetBackgroundImage(self.ImageFromColor(UIColor.FromRGB(57, 180, 211)), UIControlState.Highlighted);
        }

        public static void WarningStyle(this UIButton self)
        {
            /*
                self bootstrapStyle];
                self.backgroundColor = [UIColor colorWithRed:240/255.0 green:173/255.0 blue:78/255.0 alpha:1];
                self.layer.borderColor = [[UIColor colorWithRed:238/255.0 green:162/255.0 blue:54/255.0 alpha:1] CGColor];
                [self setBackgroundImage:[self buttonImageFromColor:[UIColor colorWithRed:237/255.0 green:155/255.0 blue:67/255.0 alpha:1]] forState:UIControlStateHighlighted];
             */
            self.BootstrapStyle();
            self.BackgroundColor = UIColor.FromRGB(240, 173, 78);
            self.Layer.BorderColor = UIColor.FromRGB(238, 162, 54).CGColor;
            self.SetBackgroundImage(self.ImageFromColor(UIColor.FromRGB(237, 155, 67)), UIControlState.Highlighted);
        }

        public static void DangerStyle(this UIButton self)
        {
            /* [self bootstrapStyle];
                self.backgroundColor = [UIColor colorWithRed:217/255.0 green:83/255.0 blue:79/255.0 alpha:1];
                self.layer.borderColor = [[UIColor colorWithRed:212/255.0 green:63/255.0 blue:58/255.0 alpha:1] CGColor];
                [self setBackgroundImage:[self buttonImageFromColor:[UIColor colorWithRed:210/255.0 green:48/255.0 blue:51/255.0 alpha:1]] forState:UIControlStateHighlighted];
             */
            self.BootstrapStyle();
            self.BackgroundColor = UIColor.FromRGB(217, 83, 79);
            self.Layer.BorderColor = UIColor.FromRGB(212, 63, 58).CGColor;
            self.SetBackgroundImage(self.ImageFromColor(UIColor.FromRGB(210, 48, 51)), UIControlState.Highlighted);
        }

        public static UIImage ImageFromColor(this UIView self, UIColor color)
        {
            /*
             *  CGRect rect = CGRectMake(0, 0, self.frame.size.width, self.frame.size.height);
                UIGraphicsBeginImageContext(rect.size);
                CGContextRef context = UIGraphicsGetCurrentContext();
                CGContextSetFillColorWithColor(context, [color CGColor]);
                CGContextFillRect(context, rect);
                UIImage *img = UIGraphicsGetImageFromCurrentImageContext();
                UIGraphicsEndImageContext();
                return img;
             */

            var rect = new CGRect(0, 0, self.Frame.Size.Width, self.Frame.Size.Height);
            UIGraphics.BeginImageContext(rect.Size);
            CGContext context = UIGraphics.GetCurrentContext();
            context.SetFillColor(color.CGColor);
            context.FillRect(rect);
            UIImage image = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            return image;
        }

        private static string[] awesomeStrings;

        public static string StringFromAwesomeIcon(AwesomeIcon icon)
        {
            if (awesomeStrings == null)
            {
                #region 定义字符
                awesomeStrings = new string[]
                { 
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    ""
                };
                #endregion
            }
            return awesomeStrings[(int)icon];
        }
    }
    public enum AwesomeIcon
    {
        Glass = 0,
        Music,
        Search,
        Envelope,
        Heart,
        Star,
        StarEmpty,
        User,
        Film,
        ThLarge,
        Th,
        ThList,
        Ok,
        Remove,
        ZoomIn,
        ZoomOut,
        Off,
        Signal,
        Cog,
        Trash,
        Home,
        File,
        Time,
        Road,
        DownloadAlt,
        Download,
        Upload,
        Inbox,
        PlayCircle,
        Repeat,
        Refresh,
        ListAlt,
        Lock,
        Flag,
        Headphones,
        VolumeOff,
        VolumeDown,
        VolumeUp,
        Qrcode,
        Barcode,
        Tag,
        Tags,
        Book,
        Bookmark,
        Print,
        Camera,
        Font,
        Bold,
        Italic,
        TextHeight,
        TextWidth,
        AlignLeft,
        AlignCenter,
        AlignRight,
        AlignJustify,
        List,
        IndentLeft,
        IndentRight,
        FacetimeVideo,
        Picture,
        Pencil,
        MapMarker,
        Adjust,
        Tint,
        Edit,
        Share,
        Check,
        Move,
        StepBackward,
        FastBackward,
        Backward,
        Play,
        Pause,
        Stop,
        Forward,
        FastForward,
        StepForward,
        Eject,
        ChevronLeft,
        ChevronRight,
        PlusSign,
        MinusSign,
        RemoveSign,
        OkSign,
        QuestionSign,
        InfoSign,
        Screenshot,
        RemoveCircle,
        OkCircle,
        BanCircle,
        ArrowLeft,
        ArrowRight,
        ArrowUp,
        ArrowDown,
        ShareAlt,
        ResizeFull,
        ResizeSmall,
        Plus,
        Minus,
        Asterisk,
        ExclamationSign,
        Gift,
        Leaf,
        Fire,
        EyeOpen,
        EyeClose,
        WarningSign,
        Plane,
        Calendar,
        Random,
        Comment,
        Magnet,
        ChevronUp,
        ChevronDown,
        Retweet,
        ShoppingCart,
        FolderClose,
        FolderOpen,
        ResizeVertical,
        ResizeHorizontal,
        BarChart,
        TwitterSign,
        FacebookSign,
        CameraRetro,
        Key,
        Cogs,
        Comments,
        ThumbsUp,
        ThumbsDown,
        StarHalf,
        HeartEmpty,
        Signout,
        LinkedinSign,
        Pushpin,
        ExternalLink,
        Signin,
        Trophy,
        GithubSign,
        UploadAlt,
        Lemon,
        Phone,
        CheckEmpty,
        BookmarkEmpty,
        PhoneSign,
        Twitter,
        Facebook,
        Github,
        Unlock,
        CreditCard,
        Rss,
        Hdd,
        Bullhorn,
        Bell,
        Certificate,
        HandRight,
        HandLeft,
        HandUp,
        HandDown,
        CircleArrowLeft,
        CircleArrowRight,
        CircleArrowUp,
        CircleArrowDown,
        Globe,
        Wrench,
        Tasks,
        Filter,
        Briefcase,
        Fullscreen,
        Group,
        Link,
        Cloud,
        Beaker,
        Cut,
        Copy,
        PaperClip,
        Save,
        SignBlank,
        Reorder,
        ListUl,
        ListOl,
        Strikethrough,
        Underline,
        Table,
        Magic,
        Truck,
        Pinterest,
        PinterestSign,
        GooglePlusSign,
        GooglePlus,
        Money,
        CaretDown,
        CaretUp,
        CaretLeft,
        CaretRight,
        Columns,
        Sort,
        SortDown,
        SortUp,
        EnvelopeAlt,
        Linkedin,
        Undo,
        Legal,
        Dashboard,
        CommentAlt,
        CommentsAlt,
        Bolt,
        Sitemap,
        Umbrella,
        Paste,
        UserMd
    }
}