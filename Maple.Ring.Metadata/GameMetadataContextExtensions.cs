using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;

namespace Maple.Ring.Metadata
{
    public static class GameMetadataContextExtensions
    {
        static MonoRuntimeContext GetNotNullValue(this MonoRuntimeContext? monoRuntimeContext)
        {
            return monoRuntimeContext ?? MonoRuntimeContext.GlobalInstance ?? MetadataCollectorException.Throw<MonoRuntimeContext>($"{typeof(MonoRuntimeContext).FullName} IS NULL");

        }

        public static ReactiveCollectionGeneric<T>.Ptr_ReactiveCollectionGeneric LoadSelf<T>(this PtrReactiveCollection<T> @this, MonoRuntimeContext? runtimeContext = default) where T : unmanaged
        {
            var ptr = @this.Ptr;
            _ = ReactiveCollectionGeneric<T>.LoadMetadata<ReactiveCollectionGeneric<T>>(runtimeContext.GetNotNullValue(), ptr, static (r, c) => new(r, c));
            return ptr;
        }

        public static ReactivePropertyGeneric<T>.Ptr_ReactivePropertyGeneric LoadSelf<T>(this PtrReactiveProperty<T> @this, MonoRuntimeContext? runtimeContext = default) where T : unmanaged
        {
            var ptr = @this.Ptr;
            _ = ReactivePropertyGeneric<T>.LoadMetadata<ReactivePropertyGeneric<T>>(runtimeContext.GetNotNullValue(), ptr, static (r, c) => new(r, c));
            return ptr;
        }


    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PtrReactiveCollection<T>(nint ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata where T : unmanaged
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly System.IntPtr m_Pointer = ptr;
        public System.IntPtr Ptr => m_Pointer;

        public static implicit operator PtrReactiveCollection<T>(System.IntPtr ptr) => new(ptr);
        public static implicit operator System.IntPtr(PtrReactiveCollection<T> ptr) => ptr.m_Pointer;
        public static implicit operator bool(PtrReactiveCollection<T> ptr) => ptr.m_Pointer != System.IntPtr.Zero;

        public override string ToString()
        {
            return m_Pointer.ToString("X8");
        }


        public void CLEAR() => this.LoadSelf<T>().CLEAR_ITEMS();

        public void ADD(T item) => this.LoadSelf<T>().ADD(item);
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PtrReactiveProperty<T>(nint ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata where T : unmanaged
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly System.IntPtr m_Pointer = ptr;
        public System.IntPtr Ptr => m_Pointer;

        public static implicit operator PtrReactiveProperty<T>(System.IntPtr ptr) => new(ptr);
        public static implicit operator System.IntPtr(PtrReactiveProperty<T> ptr) => ptr.m_Pointer;
        public static implicit operator bool(PtrReactiveProperty<T> ptr) => ptr.m_Pointer != System.IntPtr.Zero;

        public override string ToString()
        {
            return m_Pointer.ToString("X8");
        }


        public T GET_VALUE() => this.LoadSelf().GET_VALUE();
        public void SET_VALUE(T item) => this.LoadSelf().SET_VALUE(item);


        public T Value
        {
            get => this.LoadSelf().GET_VALUE();
            set => this.LoadSelf().SET_VALUE(Value);
        }
    }


}
