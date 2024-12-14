using UnityEngine;
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEditor;
using UnityEngine.UI;
using BindType = ToLuaMenu.BindType;
using System.Reflection;
using UnityEngine.EventSystems;
//using Habby;
//using Habby.Guild.Data;
//using Game;

public static class CustomSettings
{
    public static string saveDir = Application.dataPath + "/ScriptsGame/LuaFramework/Source/Generate/";    
    public static string toluaBaseType = Application.dataPath + "/ScriptsGame/LuaFramework/ToLua/BaseType/";
    public static string baseLuaDir = Application.dataPath + "../GameScripts/";
    public static string injectionFilesPath = Application.dataPath + "/ScriptsGame/LuaFramework/ToLua/Injection/";

    //导出时强制做为静态类的类型(注意customTypeList 还要添加这个类型才能导出)
    //unity 有些类作为sealed class, 其实完全等价于静态类
    public static List<Type> staticClassTypes = new List<Type>
    {        
        typeof(UnityEngine.Application),
        typeof(UnityEngine.GL),
        typeof(UnityEngine.Graphics),
        typeof(UnityEngine.Input),
        typeof(UnityEngine.Physics),
        typeof(UnityEngine.PlayerPrefs),
        typeof(UnityEngine.QualitySettings),
        typeof(UnityEngine.Resources),
        typeof(UnityEngine.RenderSettings),
        typeof(UnityEngine.Screen),
        typeof(UnityEngine.SleepTimeout),
        typeof(UnityEngine.SystemInfo),
        typeof(UnityEngine.Time),
    };

    //附加导出委托类型(在导出委托时, customTypeList 中牵扯的委托类型都会导出， 无需写在这里)
    public static DelegateType[] customDelegateList = 
    {        
        _DT(typeof(Action)),                
        _DT(typeof(UnityEngine.Events.UnityAction)),
        _DT(typeof(System.Predicate<int>)),
        _DT(typeof(System.Action<int>)),
        _DT(typeof(System.Comparison<int>)),
        _DT(typeof(System.Func<int, int>)),
    };

    public static BindType[] customTypeList_sorted()
    {
        List<BindType> _list = new List<BindType>(customTypeList);
        _list.Sort((a, b) => { return a.name.CompareTo(b.name); });
        return _list.ToArray();
    }

    //在这里添加你要导出注册到lua的类型列表
    private static BindType[] customTypeList =
    {                    
        _GT(typeof(LuaInjectionStation)),
        _GT(typeof(InjectType)),
        _GT(typeof(Debugger)).SetNameSpace(null),          
                                         
        _GT(typeof(Component)),
        _GT(typeof(Transform)),
        _GT(typeof(Material)),
        _GT(typeof(Light)),
        _GT(typeof(Rigidbody)),
        _GT(typeof(RigidbodyConstraints)),
        _GT(typeof(Camera)),
        _GT(typeof(AudioSource)),
        _GT(typeof(AudioListener)),
        _GT(typeof(Canvas)),
        _GT(typeof(NetworkReachability)),
      
        _GT(typeof(Behaviour)),
        _GT(typeof(MonoBehaviour)),
        _GT(typeof(GameObject)),
        _GT(typeof(TrackedReference)),
        _GT(typeof(Application)),
        _GT(typeof(RuntimePlatform)),
        _GT(typeof(SystemInfo)),
        _GT(typeof(PlayerPrefs)),
        _GT(typeof(Physics)),
        _GT(typeof(Physics2D)),
        _GT(typeof(SimulationMode)),
        _GT(typeof(Collider)),
        _GT(typeof(Collider2D)),
        _GT(typeof(Time)),
        _GT(typeof(Texture)),
        _GT(typeof(Texture2D)),
        _GT(typeof(Shader)),
        _GT(typeof(Renderer)),
        _GT(typeof(Screen)),
        _GT(typeof(CameraClearFlags)),
        _GT(typeof(AudioClip)),
        _GT(typeof(AssetBundle)),
        _GT(typeof(ParticleSystem)),
        _GT(typeof(AsyncOperation)).SetBaseType(typeof(System.Object)),
        _GT(typeof(LightType)),
        _GT(typeof(SleepTimeout)),
        _GT(typeof(LayoutRebuilder)),
        _GT(typeof(TouchScreenKeyboard)),
        _GT(typeof(TouchScreenKeyboardType)),

        _GT(typeof(Animator)),
        _GT(typeof(AnimatorStateInfo)),
        _GT(typeof(AnimatorCullingMode)),
        _GT(typeof(Input)),
        _GT(typeof(KeyCode)),
        _GT(typeof(SkinnedMeshRenderer)),
        _GT(typeof(Space)),
        _GT(typeof(RuntimeAnimatorController)),
        _GT(typeof(AnimatorClipInfo)),
        _GT(typeof(Sprite)),
        _GT(typeof(AspectRatioFitter)),


        _GT(typeof(MeshRenderer)),
        _GT(typeof(TextMesh)),
        _GT(typeof(BoxCollider)),
        _GT(typeof(MeshCollider)),
        _GT(typeof(SphereCollider)),
        _GT(typeof(CharacterController)),
        _GT(typeof(CapsuleCollider)),

        _GT(typeof(Animation)),
        _GT(typeof(AnimationClip)).SetBaseType(typeof(UnityEngine.Object)),
        _GT(typeof(AnimationState)),
        _GT(typeof(AnimationBlendMode)),
        _GT(typeof(QueueMode)),
        _GT(typeof(PlayMode)),
        _GT(typeof(WrapMode)),

        _GT(typeof(QualitySettings)),
        _GT(typeof(RenderSettings)),
        _GT(typeof(SkinWeights)),
        _GT(typeof(RenderTexture)),
        _GT(typeof(Resources)),
        _GT(typeof(LuaProfiler)),

        _GT(typeof(ForceMode)),
        _GT(typeof(MeshFilter)),
        _GT(typeof(Mesh)),
        _GT(typeof(SpriteRenderer)),
        _GT(typeof(SpriteMask)),
        _GT(typeof(Collision)),
        _GT(typeof(ContactPoint)),
        _GT(typeof(PointerEventData)),
        _GT(typeof(RaycastResult)),
        _GT(typeof(UnityEngine.SceneManagement.SceneManager)),
        _GT(typeof(UnityEngine.SceneManagement.Scene)),
        _GT(typeof(Font)),
        _GT(typeof(CharacterInfo)),
        _GT(typeof(UnityEngine.Video.VideoPlayer)),
        _GT(typeof(UnityEngine.Video.VideoClip)),
        _GT(typeof(LineRenderer)),
        _GT(typeof(ConstantForce)),
        _GT(typeof(ConstantForce2D)),
        
        //UGUI
        _GT(typeof(RectTransform)),
        _GT(typeof(Text)),
        _GT(typeof(Slider)),
        _GT(typeof(InputField)),
        _GT(typeof(Image)),
        _GT(typeof(Button)),
        _GT(typeof(RawImage)),
        _GT(typeof(CanvasGroup)),
        _GT(typeof(Rect)),
        _GT(typeof(Toggle)),
        _GT(typeof(LayoutElement)),
        _GT(typeof(ScrollRect)),
        _GT(typeof(TextAnchor)),
        _GT(typeof(LayoutGroup)),
        _GT(typeof(VerticalLayoutGroup)),
        _GT(typeof(HorizontalLayoutGroup)),
        _GT(typeof(GridLayoutGroup)),
        _GT(typeof(ContentSizeFitter)),
        _GT(typeof(ContentSizeFitter.FitMode)),
        _GT(typeof(RectOffset)),
        _GT(typeof(Outline)),

        _GT(typeof(TMPro.TMP_Text)),
        _GT(typeof(TMPro.TextMeshPro)),
        _GT(typeof(TMPro.TextMeshProUGUI)),
        _GT(typeof(TMPro.TMP_InputField)),
        
        _GT(typeof(UnityEngine.Tilemaps.Tilemap)),
        

        //UnityEngine.Networking
        _GT(typeof(UnityEngine.Networking.UnityWebRequest)),
        _GT(typeof(UnityEngine.Networking.MultipartFormDataSection)),
        _GT(typeof(UnityEngine.Networking.UploadHandlerRaw)),
        _GT(typeof(UnityEngine.Networking.DownloadHandlerBuffer)),
        _GT(typeof(UnityEngine.Networking.UnityWebRequestAsyncOperation)),

        /*
        //Game
        _GT(typeof(Game.CxAudioListener)),
        _GT(typeof(Game.GameManager)),
        _GT(typeof(Game.GameConfig)),
        _GT(typeof(Game.LuaManager)),
        _GT(typeof(Game.ABNode)),
        _GT(typeof(Game.UIUtil)),
        _GT(typeof(Game.ResourceManager)),
        _GT(typeof(Game.CxCamera)),
        _GT(typeof(Game.CxCameraVH)),
        _GT(typeof(Game.CxVolume)),
        _GT(typeof(Game.CxImage)),
        _GT(typeof(Game.PanelManager)),
        _GT(typeof(Game.AutoDestory)),
        _GT(typeof(Game.DeviceManager)),
        _GT(typeof(Game.LuaHandleHost)),
        _GT(typeof(Game.CxParticleGroup)),
        _GT(typeof(Game.CxTransfromUtils)),
        _GT(typeof(Game.ComTools)),
        _GT(typeof(Game.Email)),
        _GT(typeof(Game.UGFileUtil)),
        _GT(typeof(Game.TargetHolder)),
        _GT(typeof(Game.CxRayHelper)),
        _GT(typeof(Game.AutioCanvasScale)),
        _GT(typeof(Game.ComponentHolder)),
        _GT(typeof(Game.CxCharText)),
        _GT(typeof(Game.MaskTexture)),
        _GT(typeof(Game.AnnularSlider)),
        _GT(typeof(Game.TMP_TextUtil)),

        _GT(typeof(Game.CxMouseScroll)),

        _GT(typeof(Game.CxSpine)),
        _GT(typeof(Game.CxSpineUI)),
        _GT(typeof(Game.CxSpineAttacher)),
        _GT(typeof(Game.CxSpineAttacher_sprite)),
        _GT(typeof(Game.CxSpineAttacher_atlas)),
        _GT(typeof(Game.CxCheckButtonGroup)),
        _GT(typeof(Game.CxButton_aniColor)),

        _GT(typeof(Game.BaseBehaviour)),
        _GT(typeof(Game.UGUIBehaviour)),
        _GT(typeof(Game.PanelBehaviour)),
        _GT(typeof(Game.UIDropDownBehaviour)),
        _GT(typeof(Game.TMPDropDownBehaviour)),
        _GT(typeof(Game.UIToggleBehaviour)),
        _GT(typeof(Game.ColliderBehaviour)),
        _GT(typeof(Game.ScrollRectBehaviour)),

        _GT(typeof(Game.SPRenderOrder)),
        _GT(typeof(Game.TouchHandler)),
        _GT(typeof(Game.InputHandler)),
        _GT(typeof(Game.AniEventListener)),
        _GT(typeof(Game.CxTextCImage)),
        _GT(typeof(Game.RenderOrder)),
        _GT(typeof(Game.CxLayoutRebuild)),
        _GT(typeof(Game.CxOffsetByView)),
        _GT(typeof(Game.KeyboardOpener)),


        _GT(typeof(Game.CxMatrialTween)),
        _GT(typeof(Game.CxBaseScrollView)),
        _GT(typeof(Game.CxPageScrollView)),
         _GT(typeof(Game.CxVerticalScrollViewAutoCenter)),

        _GT(typeof(Game.DragEventListener)),        

        _GT(typeof(CxLanguage.CxLanguageManager)),
        _GT(typeof(Game.GameLoadPanel)),
        _GT(typeof(Game.ScrollRectListener)),


        //fmod
        _GT(typeof(Game.CxFmodManager)),
        _GT(typeof(Game.CxFmodSinglePlayer2D)),

        //tools
        _GT(typeof(Game.DrawBesizerLine)),

        //acaction
        _GT(typeof(Game.UIBaseItem)),
        _GT(typeof(Game.AcAction)),
        _GT(typeof(Game.AcCallFuncOAction)),
        _GT(typeof(Game.AcDelayTime)),
        _GT(typeof(Game.AcUpdateFunc)),
        _GT(typeof(Game.AcColorTo)),
        _GT(typeof(Game.AcFadeTo)),
        _GT(typeof(Game.AcMoveBy)),
        _GT(typeof(Game.AcMoveXBy)),
        _GT(typeof(Game.AcMoveYBy)),
        _GT(typeof(Game.AcMoveZBy)),
        _GT(typeof(Game.AcMoveTo)),
        _GT(typeof(Game.AcMoveXTo)),
        _GT(typeof(Game.AcMoveYTo)),
        _GT(typeof(Game.AcMoveZTo)),
        _GT(typeof(Game.AcMoveWorldBy)),
        _GT(typeof(Game.AcMoveWorldTo)),
        _GT(typeof(Game.AcBezierTo)),
        _GT(typeof(Game.AcBezierBy)),
        _GT(typeof(Game.AcCurveTo)),
        _GT(typeof(Game.AcCurveBy)),
        _GT(typeof(Game.AcQueue)),
        _GT(typeof(Game.AcSpawn)),
        _GT(typeof(Game.AcParabolaTo)),
        _GT(typeof(Game.ACPathMoveTo)),
        _GT(typeof(Game.AcRotateBy)),
        _GT(typeof(Game.AcRotateTo)),
        _GT(typeof(Game.AcScaleBy)),
        _GT(typeof(Game.AcScaleTo)),
        _GT(typeof(Game.AcScaleToOrthographicSize)),
        _GT(typeof(Game.AcSizeDelta)),
        _GT(typeof(Game.AcTimeAction)),
        _GT(typeof(Game.AcRTSizeDeltaTo)),
        _GT(typeof(Game.AcRTSizeDeltaBy)),
        _GT(typeof(Game.AcEase.EaseCurve)),
        _GT(typeof(Game.AcEase.BaseEase)),
        _GT(typeof(Game.AcEase.EaseCustom)),
        _GT(typeof(Game.AcEase.EaseIn)),
        _GT(typeof(Game.AcEase.EaseInBack)),
        _GT(typeof(Game.AcEase.EaseInElastic)),
        _GT(typeof(Game.AcEase.EaseInExpo)),
        _GT(typeof(Game.AcEase.EaseInOut)),
        _GT(typeof(Game.AcEase.EaseInOutBack)),
        _GT(typeof(Game.AcEase.EaseInOutExpo)),
        _GT(typeof(Game.AcEase.EaseInOutSine)),
        _GT(typeof(Game.AcEase.EaseInSine)),
        _GT(typeof(Game.AcEase.EaseOut)),
        _GT(typeof(Game.AcEase.EaseOutBack)),
        _GT(typeof(Game.AcEase.EaseOutElastic)),
        _GT(typeof(Game.AcEase.EaseOutExpo)),
        _GT(typeof(Game.AcEase.EaseOutSine)),
        _GT(typeof(Game.AcEase.EaseBounceIn)),
        _GT(typeof(Game.AcEase.EaseBounceOut)),
        _GT(typeof(Game.AcEase.EaseBounceInOut)),

        _GT(typeof(Game.AcEase.EaseInBZ)),
        _GT(typeof(Game.AcEase.EaseOutBZ)),
        _GT(typeof(Game.AcEase.EaseInOutBZ)),

        _GT(typeof(Game.AcEase.EaseInQuad)),
        _GT(typeof(Game.AcEase.EaseOutQuad)),
        _GT(typeof(Game.AcEase.EaseInOutQuad)),

        _GT(typeof(Game.AcEase.EaseInCubic)),
        _GT(typeof(Game.AcEase.EaseOutCubic)),
        _GT(typeof(Game.AcEase.EaseInOutCubic)),

        _GT(typeof(Game.AcEase.EaseInQuart)),
        _GT(typeof(Game.AcEase.EaseOutQuart)),
        _GT(typeof(Game.AcEase.EaseInOutQuart)),

        _GT(typeof(Game.AcEase.EaseInQuint)),
        _GT(typeof(Game.AcEase.EaseOutQuint)),
        _GT(typeof(Game.AcEase.EaseInOutQuint)),

        //virtual action
        _GT(typeof(VirtualAction.va_base)),
        _GT(typeof(VirtualAction.va_Action)),
        _GT(typeof(VirtualAction.va_CallFuncOAction)),
        _GT(typeof(VirtualAction.va_ColorTo)),
        _GT(typeof(VirtualAction.va_DelayTime)),
        _GT(typeof(VirtualAction.va_FadeTo)),
        _GT(typeof(VirtualAction.va_MoveBy)),
        _GT(typeof(VirtualAction.va_MoveTo)),
        _GT(typeof(VirtualAction.va_Queue)),
        _GT(typeof(VirtualAction.va_RotateBy)),
        _GT(typeof(VirtualAction.va_RotateTo)),
        _GT(typeof(VirtualAction.va_ScaleBy)),
        _GT(typeof(VirtualAction.va_ScaleTo)),
        _GT(typeof(VirtualAction.va_Spawn)),

        _GT(typeof(CxTMP.CxTMPBase)),
        _GT(typeof(CxTMP.CxTMPCharacter)),
        //GameScript
        _GT(typeof(Game.SpriteGrid)),

        _GT(typeof(Game.MatchModel)),
        _GT(typeof(Game.CxVectorLine)),
        _GT(typeof(Game.FieldMesh)),
        _GT(typeof(Game.FieldBlurComponent)),
        _GT(typeof(Game.CarDepthMapShadow)),
        _GT(typeof(Game.RaidNetService)),
        _GT(typeof(Game.CxHeadlessHttpServer)),
        

        _GT(typeof(SoftMasking.SoftMask)),

        //HabbySDK
        _GT(typeof(HabbySDKLuaManager)),
        _GT(typeof(HabbySDKLuaMail)),
        _GT(typeof(HabbySDKLuaGuild)),
        _GT(typeof(HabbySDKLuaChat)),
        _GT(typeof(HabbySDKLuaHabbyId)),
        _GT(typeof(HabbySDKLuaGoogleAccount)),
        _GT(typeof(HabbySDKLuaAppleId)),
        _GT(typeof(HabbySDKLuaFacebookAccount)),
        _GT(typeof(GuildCreatRequestData)),
        _GT(typeof(Habby.Analytics.HabbySDKLuaAnalytics)),
        _GT(typeof(Habby.Analytics.HabbyAnalytics_login)),
        _GT(typeof(Habby.HabbySdkConst)),
        _GT(typeof(HabbySDKLuaRatingAndNotification)),
        _GT(typeof(HabbySDKLuaAds)),

        _GT(typeof(Game.VideoClipHolder)),
        _GT(typeof(Game.PopTrigger)),
        _GT(typeof(Game.CopyTextToClipboard)),
        _GT(typeof(Game.MatchCar)),

        _GT(typeof(update_v2.AsyncUpdater)),

        _GT(typeof(URPManager)),
        _GT(typeof(Game.CxLoadImageFromURL)),

        _GT(typeof(WebViewCreator)),
        _GT(typeof(WebViewPlayerInfo)),
        _GT(typeof(GameLogicUrls)),*/
    };

    public static List<Type> dynamicList = new List<Type>()
    {
        typeof(MeshRenderer),

        typeof(BoxCollider),
        typeof(MeshCollider),
        typeof(SphereCollider),
        typeof(CharacterController),
        typeof(CapsuleCollider),

        typeof(Animation),
        typeof(AnimationClip),
        typeof(AnimationState),

        typeof(SkinWeights),
        typeof(RenderTexture),
        typeof(Rigidbody),
    };

    //重载函数，相同参数个数，相同位置out参数匹配出问题时, 需要强制匹配解决
    //使用方法参见例子14
    public static List<Type> outList = new List<Type>()
    {
        
    };
        
    //ngui优化，下面的类没有派生类，可以作为sealed class
    public static List<Type> sealedList = new List<Type>()
    {
        /*typeof(Transform),
        typeof(UIRoot),
        typeof(UICamera),
        typeof(UIViewport),
        typeof(UIPanel),
        typeof(UILabel),
        typeof(UIAnchor),
        typeof(UIAtlas),
        typeof(UIFont),
        typeof(UITexture),
        typeof(UISprite),
        typeof(UIGrid),
        typeof(UITable),
        typeof(UIWrapGrid),
        typeof(UIInput),
        typeof(UIScrollView),
        typeof(UIEventListener),
        typeof(UIScrollBar),
        typeof(UICenterOnChild),
        typeof(UIScrollView),        
        typeof(UIButton),
        typeof(UITextList),
        typeof(UIPlayTween),
        typeof(UIDragScrollView),
        typeof(UISpriteAnimation),
        typeof(UIWrapContent),
        typeof(TweenWidth),
        typeof(TweenAlpha),
        typeof(TweenColor),
        typeof(TweenRotation),
        typeof(TweenPosition),
        typeof(TweenScale),
        typeof(TweenHeight),
        typeof(TypewriterEffect),
        typeof(UIToggle),
        typeof(Localization),*/
    };

    public static BindType _GT(Type t)
    {
        return new BindType(t);
    }

    public static DelegateType _DT(Type t)
    {
        return new DelegateType(t);
    }    


    [MenuItem("Lua/Attach Profiler", false, 151)]
    static void AttachProfiler()
    {
        if (!Application.isPlaying)
        {
            EditorUtility.DisplayDialog("警告", "请在运行时执行此功能", "确定");
            return;
        }

        LuaClient.Instance.AttachProfiler();
    }

    [MenuItem("Lua/Detach Profiler", false, 152)]
    static void DetachProfiler()
    {
        if (!Application.isPlaying)
        {            
            return;
        }

        LuaClient.Instance.DetachProfiler();
    }
}
