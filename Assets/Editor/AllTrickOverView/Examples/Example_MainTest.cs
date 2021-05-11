using AllTrickOverView.Core;

namespace AllTrickOverView.Examples
{
    public class Example_MainTest : AExample_Base
    {
        public static TrickOverViewInfo TrickOverViewInfo =
            new TrickOverViewInfo("MainTest",
                "一个测试工具录入类",
                "Hello",
                "//None",
                "Assets/Editor/Examples/Example_MainTest",
                typeof(Example_MainTest),
                picPath : "Assets/Editor/Examples/Example_MainTest/360截图20210511114217933.jpg",
                videoPath : "");

        public override TrickOverViewInfo GetTrickOverViewInfo()
        {
            return TrickOverViewInfo;
        }
    }
}
