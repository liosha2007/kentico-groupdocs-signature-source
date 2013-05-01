using System;
using CMS.PortalControls;

public partial class CMSWebParts_Groupdocs_EmbedSignature : CMSAbstractWebPart
{
    protected void Page_Load(object sender, EventArgs e)
    {
        iframe.Attributes.Add("src", String.Format("https://apps.groupdocs.com/signature/forms/SignEmbed/{0}?referer=Kentico/1.0", GetValue("Guid")));
        iframe.Attributes.Add("width", GetValue("FrameWidth").ToString());
        iframe.Attributes.Add("height", GetValue("FrameHeight").ToString());
    }
}