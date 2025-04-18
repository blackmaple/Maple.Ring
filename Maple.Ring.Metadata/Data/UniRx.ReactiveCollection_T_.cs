using Maple.MonoGameAssistant.MetadataCollections;

namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["UniRx.dll"."UniRx"."ReactiveCollection`1"]
    /// [System.Collections.ObjectModel.Collection<T>]=>[System.Object]
    /// [UniRx.IReactiveCollection<T>]=>[System.Collections.Generic.IList<T>]=>[System.Collections.Generic.ICollection<T>]=>[System.Collections.Generic.IEnumerable<T>]=>[System.Collections.IEnumerable]=>[UniRx.IReadOnlyReactiveCollection<T>]=>[System.IDisposable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.GenericClassParentMetadataAttribute(typeof(Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.GenericClassMetadataCollector<>), typeof(ReactiveCollectionGeneric<>.Ptr_ReactiveCollectionGeneric))]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.GenericClassModelMetadataAttribute]
    public partial class ReactiveCollectionGeneric<T>
        where T : unmanaged
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ReactiveCollectionGeneric(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ReactiveCollectionGeneric(System.IntPtr ptr) => new Ptr_ReactiveCollectionGeneric(ptr);
            public static implicit operator System.IntPtr(Ptr_ReactiveCollectionGeneric ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_ReactiveCollectionGeneric ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["UniRx.dll"."UniRx"."ReactiveCollection`1"]
        /// </summary>
        partial struct Ptr_ReactiveCollectionGeneric
        {
            /// <summary>
            /// 0x0 System.Boolean isDisposed
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isDisposed", "System.Boolean")]
           public partial System.Boolean IS_DISPOSED { get; set; } 
*/

            /// <summary>
            /// 0x0 UniRx.Subject<System.Int32> countChanged
            /// class ["UniRx.dll"."UniRx"."Subject`1"]
            /// </summary>
            /// <returns>class UniRx.Subject<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("countChanged", "UniRx.Subject<System.Int32>")]
           public partial nint COUNT_CHANGED { get; set; } 
*/

            /// <summary>
            /// 0x0 UniRx.Subject<UniRx.Unit> collectionReset
            /// class ["UniRx.dll"."UniRx"."Subject`1"]
            /// </summary>
            /// <returns>class UniRx.Subject<UniRx.Unit></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("collectionReset", "UniRx.Subject<UniRx.Unit>")]
           public partial nint COLLECTION_RESET { get; set; } 
*/

            /// <summary>
            /// 0x0 UniRx.Subject<UniRx.CollectionAddEvent<T>> collectionAdd
            /// class ["UniRx.dll"."UniRx"."Subject`1"]
            /// </summary>
            /// <returns>class UniRx.Subject<UniRx.CollectionAddEvent<T>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("collectionAdd", "UniRx.Subject<UniRx.CollectionAddEvent<T>>")]
           public partial nint COLLECTION_ADD { get; set; } 
*/

            /// <summary>
            /// 0x0 UniRx.Subject<UniRx.CollectionMoveEvent<T>> collectionMove
            /// class ["UniRx.dll"."UniRx"."Subject`1"]
            /// </summary>
            /// <returns>class UniRx.Subject<UniRx.CollectionMoveEvent<T>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("collectionMove", "UniRx.Subject<UniRx.CollectionMoveEvent<T>>")]
           public partial nint COLLECTION_MOVE { get; set; } 
*/

            /// <summary>
            /// 0x0 UniRx.Subject<UniRx.CollectionRemoveEvent<T>> collectionRemove
            /// class ["UniRx.dll"."UniRx"."Subject`1"]
            /// </summary>
            /// <returns>class UniRx.Subject<UniRx.CollectionRemoveEvent<T>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("collectionRemove", "UniRx.Subject<UniRx.CollectionRemoveEvent<T>>")]
           public partial nint COLLECTION_REMOVE { get; set; } 
*/

            /// <summary>
            /// 0x0 UniRx.Subject<UniRx.CollectionReplaceEvent<T>> collectionReplace
            /// class ["UniRx.dll"."UniRx"."Subject`1"]
            /// </summary>
            /// <returns>class UniRx.Subject<UniRx.CollectionReplaceEvent<T>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("collectionReplace", "UniRx.Subject<UniRx.CollectionReplaceEvent<T>>")]
           public partial nint COLLECTION_REPLACE { get; set; } 
*/

            /// <summary>
            /// 0x0 System.Boolean disposedValue
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("disposedValue", "System.Boolean")]
           public partial System.Boolean DISPOSED_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x10 System.Collections.Generic.IList<T> items
            /// interface ["mscorlib.dll"."System.Collections.Generic"."IList`1"]
            /// </summary>
            /// <returns>interface System.Collections.Generic.IList<T></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("items", default)]
            public partial SysPtrList<T> ITEMS { get; set; }


            /// <summary>
            /// 0x18 System.Object _syncRoot
            /// class ["mscorlib.dll"."System"."Object"]
            /// </summary>
            /// <returns>class System.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_syncRoot", "System.Object")]
           public partial nint _SYNC_ROOT { get; set; } 
*/
        }

        /// <summary>
        /// class ["UniRx.dll"."UniRx"."ReactiveCollection`1"]
        /// </summary>
        partial struct Ptr_ReactiveCollectionGeneric
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection)
            /// </summary>
            /// <param name = "collection">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
           public partial void CTOR(nint collection); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.List<T> list)
            /// </summary>
            /// <param name = "list">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 0)]
           public partial void CTOR(nint list); 
*/
            /// <summary>
            ///   System.Int32 <ObserveCountChanged>b__11_0()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<ObserveCountChanged>b__11_0", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 OBSERVE_COUNT_CHANGEDB__11_0(); 
*/
            /// <summary>
            ///   System.Void ClearItems()
            /// </summary>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearItems", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR_ITEMS();

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
            ///   System.Void Dispose()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Dispose", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void DISPOSE(); 
*/
            /// <summary>
            ///   System.Void DisposeSubject(UniRx.Subject<TSubject>& subject)
            /// </summary>
            /// <param name = "subject">class UniRx.Subject<TSubject>&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DisposeSubject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UniRx.Subject<TSubject>&", 0)]
           public partial void DISPOSE_SUBJECT(nint subject); 
*/
            /// <summary>
            ///   System.Void InsertItem(System.Int32 index, T item)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InsertItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 1)]
           public partial void INSERT_ITEM(System.Int32 index, nint item); 
*/
            /// <summary>
            ///   System.Void Move(System.Int32 oldIndex, System.Int32 newIndex)
            /// </summary>
            /// <param name = "oldIndex">struct System.Int32</param>
            /// <param name = "newIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Move", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void MOVE(System.Int32 oldIndex, System.Int32 newIndex); 
*/
            /// <summary>
            ///   System.Void MoveItem(System.Int32 oldIndex, System.Int32 newIndex)
            /// </summary>
            /// <param name = "oldIndex">struct System.Int32</param>
            /// <param name = "newIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MoveItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void MOVE_ITEM(System.Int32 oldIndex, System.Int32 newIndex); 
*/
            /// <summary>
            ///   System.IObservable<UniRx.CollectionAddEvent<T>> ObserveAdd()
            /// </summary>
            /// <returns>interface System.IObservable<UniRx.CollectionAddEvent<T>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ObserveAdd", "System.IObservable<UniRx.CollectionAddEvent<T>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint OBSERVE_ADD(); 
*/
            /// <summary>
            ///   System.IObservable<System.Int32> ObserveCountChanged(System.Boolean notifyCurrentCount)
            /// </summary>
            /// <param name = "notifyCurrentCount">struct System.Boolean</param>
            /// <returns>interface System.IObservable<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ObserveCountChanged", "System.IObservable<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial nint OBSERVE_COUNT_CHANGED(System.Boolean notifyCurrentCount); 
*/
            /// <summary>
            ///   System.IObservable<UniRx.CollectionMoveEvent<T>> ObserveMove()
            /// </summary>
            /// <returns>interface System.IObservable<UniRx.CollectionMoveEvent<T>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ObserveMove", "System.IObservable<UniRx.CollectionMoveEvent<T>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint OBSERVE_MOVE(); 
*/
            /// <summary>
            ///   System.IObservable<UniRx.CollectionRemoveEvent<T>> ObserveRemove()
            /// </summary>
            /// <returns>interface System.IObservable<UniRx.CollectionRemoveEvent<T>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ObserveRemove", "System.IObservable<UniRx.CollectionRemoveEvent<T>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint OBSERVE_REMOVE(); 
*/
            /// <summary>
            ///   System.IObservable<UniRx.CollectionReplaceEvent<T>> ObserveReplace()
            /// </summary>
            /// <returns>interface System.IObservable<UniRx.CollectionReplaceEvent<T>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ObserveReplace", "System.IObservable<UniRx.CollectionReplaceEvent<T>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint OBSERVE_REPLACE(); 
*/
            /// <summary>
            ///   System.IObservable<UniRx.Unit> ObserveReset()
            /// </summary>
            /// <returns>interface System.IObservable<UniRx.Unit></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ObserveReset", "System.IObservable<UniRx.Unit>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint OBSERVE_RESET(); 
*/
            /// <summary>
            ///   System.Void RemoveItem(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void REMOVE_ITEM(System.Int32 index); 
*/
            /// <summary>
            ///   System.Void SetItem(System.Int32 index, T item)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 1)]
           public partial void SET_ITEM(System.Int32 index, nint item); 
*/
        }

        /// <summary>
        /// class ["mscorlib.dll"."System.Collections.ObjectModel"."Collection`1"]
        /// </summary>
        partial struct Ptr_ReactiveCollectionGeneric
        {
            /// <summary>
            /// static  System.Boolean IsCompatibleObject(System.Object value)
            /// </summary>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsCompatibleObject", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
           public static partial System.Boolean IS_COMPATIBLE_OBJECT(nint value); 
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
            ///   System.Void .ctor(System.Collections.Generic.IList<T> list)
            /// </summary>
            /// <param name = "list">interface System.Collections.Generic.IList<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IList<T>", 0)]
           public partial void CTOR(nint list); 
*/
            /// <summary>
            ///   System.Void Add(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Add", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            // [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public partial void ADD(T item);

            /// <summary>
            ///   System.Void Clear()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clear", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CLEAR(); 
*/
            /// <summary>
            ///   System.Void ClearItems()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearItems", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CLEAR_ITEMS(); 
*/
            /// <summary>
            ///   System.Boolean Contains(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           public partial System.Boolean CONTAINS(nint item); 
*/
            /// <summary>
            ///   System.Void CopyTo(T[] array, System.Int32 index)
            /// </summary>
            /// <param name = "array">class T[]</param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void COPY_TO(nint array, System.Int32 index); 
*/
            /// <summary>
            ///   System.Int32 get_Count()
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Count", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_COUNT();

            /// <summary>
            ///   T get_Item(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>class T</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Item", default, CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial T GET_ITEM(System.Int32 index);

            /// <summary>
            ///   System.Collections.Generic.IList<T> get_Items()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IList<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Items", "System.Collections.Generic.IList<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_ITEMS(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerator<T> GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerator<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnumerator", "System.Collections.Generic.IEnumerator<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Int32 IndexOf(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           public partial System.Int32 INDEX_OF(nint item); 
*/
            /// <summary>
            ///   System.Void Insert(System.Int32 index, T item)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Insert", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 1)]
           public partial void INSERT(System.Int32 index, nint item); 
*/
            /// <summary>
            ///   System.Void InsertItem(System.Int32 index, T item)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InsertItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 1)]
           public partial void INSERT_ITEM(System.Int32 index, nint item); 
*/
            /// <summary>
            ///   System.Boolean Remove(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Remove", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           public partial System.Boolean REMOVE(nint item); 
*/
            /// <summary>
            ///   System.Void RemoveAt(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveAt", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void REMOVE_AT(System.Int32 index); 
*/
            /// <summary>
            ///   System.Void RemoveItem(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void REMOVE_ITEM(System.Int32 index); 
*/
            /// <summary>
            ///   System.Void set_Item(System.Int32 index, T value)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "value">class T</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Item", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 1)]
           public partial void SET_ITEM(System.Int32 index, nint value); 
*/
            /// <summary>
            ///   System.Void SetItem(System.Int32 index, T item)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 1)]
           public partial void SET_ITEM(System.Int32 index, nint item); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.ICollection<T>.get_IsReadOnly", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean SYSTEM_COLLECTIONS_GENERIC_I_COLLECTION_TGET_IS_READ_ONLY(); 
*/
            /// <summary>
            ///   System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
            /// </summary>
            /// <param name = "array">abstract class System.Array</param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.ICollection.CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Array", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void SYSTEM_COLLECTIONS_I_COLLECTION_COPY_TO(nint array, System.Int32 index); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.ICollection.get_IsSynchronized()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.ICollection.get_IsSynchronized", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean SYSTEM_COLLECTIONS_I_COLLECTIONGET_IS_SYNCHRONIZED(); 
*/
            /// <summary>
            ///   System.Object System.Collections.ICollection.get_SyncRoot()
            /// </summary>
            /// <returns>class System.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.ICollection.get_SyncRoot", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint SYSTEM_COLLECTIONS_I_COLLECTIONGET_SYNC_ROOT(); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IEnumerable.GetEnumerator", "System.Collections.IEnumerator", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint SYSTEM_COLLECTIONS_I_ENUMERABLE_GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Int32 System.Collections.IList.Add(System.Object value)
            /// </summary>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.Add", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
           public partial System.Int32 SYSTEM_COLLECTIONS_I_LIST_ADD(nint value); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IList.Contains(System.Object value)
            /// </summary>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
           public partial System.Boolean SYSTEM_COLLECTIONS_I_LIST_CONTAINS(nint value); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IList.get_IsFixedSize()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.get_IsFixedSize", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean SYSTEM_COLLECTIONS_I_LISTGET_IS_FIXED_SIZE(); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IList.get_IsReadOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.get_IsReadOnly", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean SYSTEM_COLLECTIONS_I_LISTGET_IS_READ_ONLY(); 
*/
            /// <summary>
            ///   System.Object System.Collections.IList.get_Item(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>class System.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.get_Item", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial nint SYSTEM_COLLECTIONS_I_LISTGET_ITEM(System.Int32 index); 
*/
            /// <summary>
            ///   System.Int32 System.Collections.IList.IndexOf(System.Object value)
            /// </summary>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.IndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
           public partial System.Int32 SYSTEM_COLLECTIONS_I_LIST_INDEX_OF(nint value); 
*/
            /// <summary>
            ///   System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.Insert", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
           public partial void SYSTEM_COLLECTIONS_I_LIST_INSERT(System.Int32 index, nint value); 
*/
            /// <summary>
            ///   System.Void System.Collections.IList.Remove(System.Object value)
            /// </summary>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.Remove", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
           public partial void SYSTEM_COLLECTIONS_I_LIST_REMOVE(nint value); 
*/
            /// <summary>
            ///   System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.set_Item", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
           public partial void SYSTEM_COLLECTIONS_I_LISTSET_ITEM(System.Int32 index, nint value); 
*/
        }
    }
}