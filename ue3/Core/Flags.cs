namespace ue3;

[Flags]
public enum EObjectFlags : ulong
{
  RF_InSingularFunc = 0x0000000000000002, // In a singular function.
  RF_StateChanged = 0x0000000000000004, // Object did a state change.
  RF_DebugPostLoad = 0x0000000000000008, // For debugging PostLoad calls.
  RF_DebugSerialize = 0x0000000000000010, // For debugging Serialize calls.
  RF_DebugFinishDestroyed = 0x0000000000000020, // For debugging FinishDestroy calls.
  RF_EdSelected = 0x0000000000000040, // Object is selected in one of the editors browser windows.
  RF_ZombieComponent = 0x0000000000000080, // This component's template was deleted, so should not be used.

  RF_Protected = 0x0000000000000100, // Property is protected (may only be accessed from its owner class or subclasses)
  RF_ClassDefaultObject = 0x0000000000000200, // this object is its class's default object

  RF_ArchetypeObject = 0x0000000000000400, // this object is a template for another object - treat like a class default object

  RF_ForceTagExp = 0x0000000000000800, // Forces this object to be put into the export table when saving a package regardless of outer
  RF_TokenStreamAssembled = 0x0000000000001000, // Set if reference token stream has already been assembled

  RF_MisalignedObject =
    0x0000000000002000, // Object's size no longer matches the size of its C++ class (only used during make, for native classes whose properties have changed)
  RF_RootSet = 0x0000000000004000, // Object will not be garbage collected, even if unreferenced.
  RF_BeginDestroyed = 0x0000000000008000, // BeginDestroy has been called on the object.
  RF_FinishDestroyed = 0x0000000000010000, // FinishDestroy has been called on the object.

  RF_DebugBeginDestroyed =
    0x0000000000020000, // Whether object is rooted as being part of the root set (garbage collection)
  RF_MarkedByCooker = 0x0000000000040000, // Marked by content cooker.
  RF_LocalizedResource = 0x0000000000080000, // Whether resource object is localized.
  RF_InitializedProps = 0x0000000000100000, // whether InitProperties has been called on this object

  RF_PendingFieldPatches =
    0x0000000000200000, //@script patcher: indicates that this struct will receive additional member properties from the script patcher

  RF_IsCrossLevelReferenced =
    0x0000000000400000, // This object has been pointed to by a cross-level reference, and therefore requires additional cleanup upon deletion

  // unused                  = 0x0000000000800000,
  // unused                  = 0x0000000001000000,
  // unused                  = 0x0000000002000000,
  // unused                  = 0x0000000004000000,
  // unused                  = 0x0000000008000000,
  // unused                  = 0x0000000010000000,
  // unused                  = 0x0000000020000000,
  // unused                  = 0x0000000040000000,
  RF_Saved = 0x0000000080000000, // Object has been saved via SavePackage. Temporary.
  RF_Transactional = 0x0000000100000000, // Object is transactional.
  RF_Unreachable = 0x0000000200000000, // Object is not reachable on the object graph.
  RF_Public = 0x0000000400000000, // Object is visible outside its package.
  RF_TagImp = 0x0000000800000000, // Temporary import tag in load/save.
  RF_TagExp = 0x0000001000000000, // Temporary export tag in load/save.
  RF_Obsolete = 0x0000002000000000, // Object marked as obsolete and should be replaced.
  RF_TagGarbage = 0x0000004000000000, // Check during garbage collection.

  RF_DisregardForGC =
    0x0000008000000000, // Object is being disregard for GC as its static and itself and all references are always loaded.
  RF_PerObjectLocalized = 0x0000010000000000, // Object is localized by instance name, not by class.
  RF_NeedLoad = 0x0000020000000000, // During load, indicates object needs loading.
  RF_AsyncLoading = 0x0000040000000000, // Object is being asynchronously loaded.

  RF_NeedPostLoadSubobjects =
    0x0000080000000000, // During load, indicates that the object still needs to instance subobjects and fixup serialized component references
  RF_Suppress = 0x0000100000000000, // @warning: Mirrored in UnName.h. Suppressed log name.
  RF_InEndState = 0x0000200000000000, // Within an EndState call.
  RF_Transient = 0x0000400000000000, // Don't save object.
  RF_Cooked = 0x0000800000000000, // Whether the object has already been cooked
  RF_LoadForClient = 0x0001000000000000, // In-file load for client.
  RF_LoadForServer = 0x0002000000000000, // In-file load for client.
  RF_LoadForEdit = 0x0004000000000000, // In-file load for client.
  RF_Standalone = 0x0008000000000000, // Keep object around for editing even if unreferenced.
  RF_NotForClient = 0x0010000000000000, // Don't load this object for the game client.
  RF_NotForServer = 0x0020000000000000, // Don't load this object for the game server.
  RF_NotForEdit = 0x0040000000000000, // Don't load this object for the editor.

  // unused                  = 0x0080000000000000,
  RF_NeedPostLoad = 0x0100000000000000, // Object needs to be postloaded.
  RF_HasStack = 0x0200000000000000, // Has execution stack.
  RF_Native = 0x0400000000000000, // Native (UClass only).
  RF_Marked = 0x0800000000000000, // Marked (for debugging).
  RF_ErrorShutdown = 0x1000000000000000, // ShutdownAfterError called.
  RF_PendingKill = 0x2000000000000000, // Objects that are pending destruction (invalid for gameplay but valid map)
  // unused                  = 0x4000000000000000,
  // unused                  = 0x8000000000000000,

  // All context flags.
  RF_ContextFlags = RF_NotForClient | RF_NotForServer | RF_NotForEdit,

  // Flags affecting loading.
  RF_LoadContextFlags = RF_LoadForClient | RF_LoadForServer | RF_LoadForEdit,

  // Flags to load from Unrealfiles.
  RF_Load = RF_ContextFlags | RF_LoadContextFlags | RF_Public | RF_Standalone | RF_Native | RF_Obsolete |
            RF_Protected | RF_Transactional | RF_HasStack | RF_PerObjectLocalized | RF_ClassDefaultObject |
            RF_ArchetypeObject | RF_LocalizedResource,

  // Flags to persist across loads.
  RF_Keep = RF_Native | RF_Marked | RF_PerObjectLocalized | RF_MisalignedObject | RF_DisregardForGC | RF_RootSet |
            RF_LocalizedResource,

  // Script-accessible flags.
  RF_ScriptMask = RF_Transactional | RF_Public | RF_Transient | RF_NotForClient | RF_NotForServer | RF_NotForEdit |
                  RF_Standalone,

  // Undo/redo will store/restore these.
  RF_UndoRedoMask = RF_PendingKill,

  // Sub-map will inherit these flags from their SuperObject.
  RF_PropagateToSubObjects = RF_Public | RF_ArchetypeObject | RF_Transactional,

  RF_AllFlags = 0xFFFFFFFFFFFFFFFF
}

[Flags]
public enum EPropertyFlags : ulong
{
  CPF_Edit = 0x0000000000000001, // Property is user-settable in the editor.
  CPF_Const = 0x0000000000000002, // Actor's patched_property always matches class's default actor patched_property.
  CPF_Input = 0x0000000000000004, // Variable is writable by the input system.
  CPF_ExportObject = 0x0000000000000008, // Object can be exported with actor.
  CPF_OptionalParm = 0x0000000000000010, // Optional parameter (if CPF_Param is set).
  CPF_Net = 0x0000000000000020, // Property is relevant to network replication.
  CPF_EditFixedSize = 0x0000000000000040, // Indicates that elements of an array can be modified, but its size cannot be changed.
  CPF_Parm = 0x0000000000000080, // Function/When call parameter.
  CPF_OutParm = 0x0000000000000100, // Value is copied out after function call.
  CPF_SkipParm = 0x0000000000000200, // Property is a short-circuitable evaluation function parm.
  CPF_ReturnParm = 0x0000000000000400, // Return value.
  CPF_CoerceParm = 0x0000000000000800, // Coerce args into this function parameter.
  CPF_Native = 0x0000000000001000, // Property is native: C++ code is responsible for serializing it.
  CPF_Transient = 0x0000000000002000, // Property is transient: shouldn't be saved, zero-filled at load time.
  CPF_Config = 0x0000000000004000, // Property should be loaded/saved as permanent profile.
  CPF_Localized = 0x0000000000008000, // Property should be loaded as localizable text.

  CPF_EditConst = 0x0000000000020000, // Property is uneditable in the editor.
  CPF_GlobalConfig = 0x0000000000040000, // Load config from base class, not subclass.
  CPF_Component = 0x0000000000080000, // Property containts component references.
  CPF_AlwaysInit = 0x0000000000100000, // Property should never be exported as NoInit

  CPF_DuplicateTransient =
    0x0000000000200000, // Property should always be reset to the default value during any type of duplication (copy/paste, binary duplication, etc.)
  CPF_NeedCtorLink = 0x0000000000400000, // Fields need construction/destruction.
  CPF_NoExport = 0x0000000000800000, // Property should not be exported to the native class header file.
  CPF_NoImport = 0x0000000001000000, // Property should not be imported when creating an object from text (copy/paste)
  CPF_NoClear = 0x0000000002000000, // Hide clear (and browse) button.
  CPF_EditInline = 0x0000000004000000, // Edit this object reference inline.

  CPF_EditInlineUse = 0x0000000010000000, // EditInline with Use button.
  CPF_Deprecated = 0x0000000020000000, // Property is deprecated.  Read it from an archive, but don't save it.
  CPF_DataBinding = 0x0000000040000000, // Indicates that this patched_property should be exposed to data stores
  CPF_SerializeText = 0x0000000080000000, // Native patched_property should be serialized as text (ImportText, ExportText)

  CPF_RepNotify = 0x0000000100000000, // Notify actors when a patched_property is replicated
  CPF_Interp = 0x0000000200000000, // interpolatable patched_property for use with matinee
  CPF_NonTransactional = 0x0000000400000000, // Property isn't transacted

  CPF_EditorOnly = 0x0000000800000000, // Property should only be loaded in the editor
  CPF_NotForConsole = 0x0000001000000000, // Property should not be loaded on console (or be a console cooker commandlet)

  CPF_RepRetry =
    0x0000002000000000, // retry replication of this patched_property if it fails to be fully sent (e.g. object references not yet available to serialize over the network)
  CPF_PrivateWrite = 0x0000004000000000, // patched_property is const outside of the class it was declared in
  CPF_ProtectedWrite = 0x0000008000000000, // patched_property is const outside of the class it was declared in and subclasses

  CPF_ArchetypeProperty = 0x0000010000000000, // patched_property should be ignored by archives which have ArIgnoreArchetypeRef set

  CPF_EditHide = 0x0000020000000000, // patched_property should never be shown in a properties window.
  CPF_EditTextBox = 0x0000040000000000, // patched_property can be edited using a text dialog box.

  CPF_CrossLevelPassive =
    0x0000100000000000, // patched_property can point across levels, and will be serialized properly, but assumes it's target exists in-game (non-editor)

  CPF_CrossLevelActive =
    0x0000200000000000, // patched_property can point across levels, and will be serialized properly, and will be updated when the target is streamed in/out

  /** @name Combinations flags */
  //@{

  /**
   * a combination of both cross level types
   */
  CPF_CrossLevel = CPF_CrossLevelPassive | CPF_CrossLevelActive,
  CPF_ParmFlags = CPF_OptionalParm | CPF_Parm | CPF_OutParm | CPF_SkipParm | CPF_ReturnParm | CPF_CoerceParm,
  CPF_PropagateFromStruct = CPF_Const | CPF_Native | CPF_Transient,

  CPF_PropagateToArrayInner = CPF_ExportObject | CPF_EditInline | CPF_EditInlineUse | CPF_Localized | CPF_Component | CPF_Config | CPF_AlwaysInit |
                              CPF_EditConst | CPF_Deprecated | CPF_SerializeText | CPF_CrossLevel,

  /**
   * the flags that should never be set on interface properties
   */
  CPF_InterfaceClearMask = CPF_NeedCtorLink | CPF_ExportObject,

  CPF_AllFlags = 0xFFFFFFFFFFFFFFFF
}