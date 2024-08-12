namespace ue3;

public partial class UComponent
{
  public override void Serialise(FArchive archive)
  {
    archive.Serialise(ref TemplateOwnerClass);

    if (IsTemplate(EObjectFlags.RF_ClassDefaultObject))
    {
      archive.Serialise(ref TemplateName);
    }

    base.Serialise(archive);
  }
}