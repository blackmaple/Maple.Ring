namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["UniRx.dll"."UniRx"."ReactiveProperty`1"]
    /// [System.Object]
    /// [UniRx.IReactiveProperty<T>]=>[UniRx.IReadOnlyReactiveProperty<T>]=>[System.IObservable<T>]=>[System.IDisposable]=>[UniRx.IOptimizedObservable<T>]=>[UniRx.IObserverLinkedList<T>]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.GenericClassParentMetadataAttribute(typeof(Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.GenericClassMetadataCollector<>), typeof(ReactivePropertyGeneric<>.Ptr_ReactivePropertyGeneric))]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.GenericClassModelMetadataAttribute]
    public partial class ReactivePropertyGeneric<T>
        where T : unmanaged
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ReactivePropertyGeneric(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ReactivePropertyGeneric(System.IntPtr ptr) => new Ptr_ReactivePropertyGeneric(ptr);
            public static implicit operator System.IntPtr(Ptr_ReactivePropertyGeneric ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_ReactivePropertyGeneric ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["UniRx.dll"."UniRx"."ReactiveProperty`1"]
        /// </summary>
        partial struct Ptr_ReactivePropertyGeneric
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.IEqualityComparer<T> defaultEqualityComparer
            /// interface ["mscorlib.dll"."System.Collections.Generic"."IEqualityComparer`1"]
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEqualityComparer<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defaultEqualityComparer", "System.Collections.Generic.IEqualityComparer<T>")]
           public static partial nint DEFAULT_EQUALITY_COMPARER { get; set; } 
*/

            /// <summary>
            /// 0x0 T value
            /// class ["UniRx.dll".""."T"]
            /// </summary>
            /// <returns>class T</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("value", default)]
            public partial T VALUE { get; set; }


            /// <summary>
            /// 0x0 UniRx.ObserverNode<T> root
            /// class ["UniRx.dll"."UniRx"."ObserverNode`1"]
            /// </summary>
            /// <returns>class UniRx.ObserverNode<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("root", "UniRx.ObserverNode<T>")]
           public partial nint ROOT { get; set; } 
*/

            /// <summary>
            /// 0x0 UniRx.ObserverNode<T> last
            /// class ["UniRx.dll"."UniRx"."ObserverNode`1"]
            /// </summary>
            /// <returns>class UniRx.ObserverNode<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("last", "UniRx.ObserverNode<T>")]
           public partial nint LAST { get; set; } 
*/

            /// <summary>
            /// 0x0 System.Boolean isDisposed
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isDisposed", "System.Boolean")]
           public partial System.Boolean IS_DISPOSED { get; set; } 
*/
        }

        /// <summary>
        /// class ["UniRx.dll"."UniRx"."ReactiveProperty`1"]
        /// </summary>
        partial struct Ptr_ReactivePropertyGeneric
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial void CCTOR(); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void .ctor(T initialValue)
            /// </summary>
            /// <param name = "initialValue">class T</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           public partial void CTOR(nint initialValue); 
*/
            /// <summary>
            ///   System.Void Dispose()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Dispose", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void DISPOSE(); 
*/
            /// <summary>
            ///   System.Void Dispose(System.Boolean disposing)
            /// </summary>
            /// <param name = "disposing">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Dispose", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void DISPOSE(System.Boolean disposing); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEqualityComparer<T> get_EqualityComparer()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEqualityComparer<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EqualityComparer", "System.Collections.Generic.IEqualityComparer<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_EQUALITY_COMPARER(); 
*/
            /// <summary>
            ///   System.Boolean get_HasValue()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_HasValue", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_HAS_VALUE(); 
*/
            /// <summary>
            ///   T get_Value()
            /// </summary>
            /// <returns>class T</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Value", default, CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial T GET_VALUE();

            /// <summary>
            ///   System.Boolean IsRequiredSubscribeOnCurrentThread()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsRequiredSubscribeOnCurrentThread", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean IS_REQUIRED_SUBSCRIBE_ON_CURRENT_THREAD(); 
*/
            /// <summary>
            ///   System.Void RaiseOnNext(T& value)
            /// </summary>
            /// <param name = "value">class T&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RaiseOnNext", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 0)]
           public partial void RAISE_ON_NEXT(nint value); 
*/
            /// <summary>
            ///   System.Void set_Value(T value)
            /// </summary>
            /// <param name = "value">class T</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Value", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            //  [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute(default(String), 0)]
            public partial void SET_VALUE(T value);

            /// <summary>
            ///   System.Void SetValue(T value)
            /// </summary>
            /// <param name = "value">class T</param>
            /// <returns>struct System.Void</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            ////      [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            //public partial void SET_VALUE(T value);

            /// <summary>
            ///   System.Void SetValueAndForceNotify(T value)
            /// </summary>
            /// <param name = "value">class T</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetValueAndForceNotify", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           public partial void SET_VALUE_AND_FORCE_NOTIFY(nint value); 
*/
            /// <summary>
            ///   System.IDisposable Subscribe(System.IObserver<T> observer)
            /// </summary>
            /// <param name = "observer">interface System.IObserver<T></param>
            /// <returns>interface System.IDisposable</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Subscribe", "System.IDisposable", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IObserver<T>", 0)]
           public partial nint SUBSCRIBE(nint observer); 
*/
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint TO_STRING(); 
*/
            /// <summary>
            ///   System.Void UniRx.IObserverLinkedList<T>.UnsubscribeNode(UniRx.ObserverNode<T> node)
            /// </summary>
            /// <param name = "node">class UniRx.ObserverNode<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UniRx.IObserverLinkedList<T>.UnsubscribeNode", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UniRx.ObserverNode<T>", 0)]
           public partial void UNI_RX_I_OBSERVER_LINKED_LIST_T_UNSUBSCRIBE_NODE(nint node); 
*/
        }
    }
}