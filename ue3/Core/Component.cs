namespace ue3;

public partial class UComponent
{
  public override void Serialise(FArchive Archive)
  {
    Archive.Serialise(ref TemplateOwnerClass);

    if (IsTemplate(EObjectFlags.RF_ClassDefaultObject))
    {
      Archive.Serialise(ref TemplateName);
    }

    base.Serialise(Archive);
  }
}