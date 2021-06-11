# UnityToolchainsTrick
提供一些UnityEditor工具链开发的常用小技巧与示例(Provides some common tips and examples for developing the UnityEditor toolchain)  

## 视频教程  
* [Unity编辑器开发常用小技巧(B站)](https://www.bilibili.com/video/BV1nh411U7iU)  

## 博客  
* [Unity编辑器拓展Wiki开源项目，装得下，世界都是你的-By 烟雨](https://zhuanlan.zhihu.com/p/364250160)  

## OverViewWindow
本项目提供了一个用于预览所有编辑器拓展样式的EditorWindow，可通过Tools-AllTrickOverView进行打开，使用教程参见[Unity编辑器拓展Wiki开源项目，装得下，世界都是你的-By 烟雨](https://zhuanlan.zhihu.com/p/364250160)

**注意，此插件基于Odin进行制作，所以需要项目中导入Odin插件，Odin官网：[https://odininspector.com/](https://odininspector.com/)**

如果不需要此预览插件，前往并删除 **Assets/Editor/AllTrickOverView** 目录即可
![](./ReadmePngs/OverViewWindow.png)

## 效果列表  
### [1.Clone一份UnityCsReference并时常回顾](https://github.com/Unity-Technologies/UnityCsReference)  
### [2.使用Odin Inspector插件](https://odininspector.com)  
### [3.EditorIcons](Assets/Editor/Examples/Example_03_EditorIcons)  
<img src="https://github.com/XINCGer/UnityToolchainsTrick/blob/main/Preview/Example_03_EditorIcons.png" width="200" height="200"/><br/>  
### [4.GUIStylesPreview](Assets/Editor/Examples/Example_04_GUIStyles)  
<img src="https://github.com/XINCGer/UnityToolchainsTrick/blob/main/Preview/Example_04_GUIStyles.png" width="200" height="200"/><br/>  
### [5.编辑下通过代码修改保存资产的方法](Assets/Editor/Examples/Example_05_SaveAssets)  
### [6.EditorWindow上画一条带有箭头的线](Assets/Editor/Examples/Example_06_DrawArrowLine)  
### [7.MissingPrefab查找](Assets/Editor/Examples/Example_07_MissingPrefabChecker)  
### [8.MissingComponent查找](Assets/Editor/Examples/Example_08_MissingComponentChecker)  
### [9.AvatarPreview实现](Assets/Editor/Examples/Example_09_AvatarPreview)  
### [10.TimeControl实现](Assets/Editor/Examples/Example_10_TimeControl)  
### [11.EditorWindow的showButton使用](Assets/Editor/Examples/Example_11_ShowButtonEditorWindow)  
### [12.Preference拓展实现](Assets/Editor/Examples/Example_12_Preference)  
### [13.Gizmos的用法](Assets/Editor/Examples/Example_13_GizmosExstension)  
### [14.编辑器下读取Excel表格共享的问题](Assets/Editor/Examples/Example_14_ExcelShareRead)  
### [15.EditorWindow代码停靠与合并](Assets/Editor/Examples/Example_15_SubWindowDock)  
### [16.创建多个SceneView等窗口](Assets/Editor/Examples/Example_16_MoreSceneView)  
### [17.EditorWindow层级管理](Assets/Editor/Examples/Example_17_MultiWindowLayerManagement)  
### [18.SceneView的拓展](Assets/Editor/Examples/Example_18_SceneViewExtension)  
### [19.特效快速预览](Assets/Editor/Examples/Example_19_ParticleSystemPreview)  
### [20.改变UnityEditor的标题栏](Assets/Editor/Examples/Example_20_TitleModifier)  
### [21.变体统计工具](Assets/Editor/Examples/Example_21_ShaderKit)  
### [22.Tools.current、Tools.viewTool](Assets/Editor/Examples/Example_22_ToolsAPI)  
### [23.Unity 侦听进入播放模式、Unity加载时初始化编辑器类](Assets/Editor/Examples/Example_23_EditorEventListener)  
### [24.Unity在Editor下获取键盘等Input事件](Assets/Editor/Examples/Example_24_GetInputEvent)  
### [25.Editor下监听全局按键事件](Assets/Editor/Examples/Example_25_GlobalInputEvent)  
### [26.预制体的修改与保存](Assets/Editor/Examples/Example_26_PrefabModify)  
### [27.EditorWindow右键弹出菜单](Assets/Editor/Examples/Example_27_EditorWindowContextClick)  
### [28.代码锁定场景物体不可点击选中](Assets/Editor/Examples/Example_28_SceneViewLock)  
### [29.获取动画曲线的预览](Assets/Editor/Examples/Example_29_AnimationCurvePreview)  
### [30.复合枚举实现UnityEditor中下多选下拉栏](Assets/Editor/Examples/Example_30_CompositeEnum)  
### [31.Transform拓展增加复制粘贴](Assets/Editor/Examples/Example_31_ExtendedTransformEditor)
### [32.AdvancedDropDown使用案例](Assets/Editor/Examples/Example_32_AdvancedDropDown)
### [33.ProjectWindowItemOnGUI使用:显示文件大小和后缀](Assets/Editor/Examples/Example_33_ProjectWindowItemOnGUI)
### [34.LinkField:可链接工程文件和URL](Assets/Editor/Examples/Example_34_LinkField)
### [35.SetObjectIcon:设置Object图标](Assets/Editor/Examples/Example_35_SetObjectIcon)
### [36.进入开发者模式](Assets/Editor/Examples/Example_36_DeveloperMode)
### [37.在EditorWindow中显示WebView](Assets/Editor/Examples/Example_37_WebViewEditorWindow)
### [38.在EditorWindow中播放VideoClip](Assets/Editor/Examples/Example_38_VideoEditorWindow)
### [39.SceneVisibility](Assets/Editor/Examples/Example_39_SceneVisibility)
### [40.使用NotKeyable避免动画误操作修改参数](Assets/Editor/Examples/Example_40_NotKeyable)
### [41.打开文件拓展](Assets/Editor/Examples/Example_41_OpenExtension)
### [42.BoundsHandle](Assets/Editor/Examples/Example_42_BoundsHandle)
### [43.MoreInspector](Assets/Editor/Examples/Example_43_MoreInspector)
### [44.ReplacementComponents](Assets/Editor/Examples/Example_44_ReplacementComponents)  
### [45.仿Odin的左侧树型菜单](Assets/Editor/Examples/Example_45_MenuEditorWindow)  
### [46.查找代码内的中文](Assets/Editor/Examples/Example_46_FindChinese)  
### [47.一行代码绘制普通对象的功能](Assets/Editor/Examples/Example_47_DrawNormalObject)  
### [48.自动处理九宫格工具](https://github.com/kyubuns/Auto9Slicer)  
### [49.利用友元访问内部api](Assets/Editor/Examples/Example_49_Friend)  
### [50.监听Unity编辑器聚焦/失焦](Assets/Editor/Examples/Example_50_UnityEditorFocus)
### [51.射线检测](Assets/Editor/Examples/Example_51_RaycastTargetChecker)
### [52.反射信息缓存](Assets/Editor/Examples/Example_52_Utility_TypeCache_Attribute)
### [53.自定义资产图标](Assets/Editor/Examples/Example_53_CustomAssetsIcon)  
### [54.Unity 引用查找工具-ReferenceFinder](https://github.com/blueberryzzz/ReferenceFinder)  

## QQ技术交流群  
群号：996526739  
<img src="https://github.com/XINCGer/UnityToolchainsTrick/blob/main/QQGroupQR.jpg" width="150" height="230" alt="加群二维码"/><br/>  
