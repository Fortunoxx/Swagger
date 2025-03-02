using Microsoft.AspNetCore.Mvc;

[ApiVersion("1.0", Deprecated = true)]
[ApiVersion("2.0")]
[ApiController]
[Route("api/[controller]")]
public class VersionsController : ControllerBase
{
    [MapToApiVersion("1.0")]
    [HttpGet(Name = "GetValueVersion1")]
    public ActionResult<KeyValuePair<string, string>> GetValueVersion1()
    {
        return new KeyValuePair<string, string>("Version", "1.0");
    }

    [MapToApiVersion("2.0")]
    [HttpGet(Name = "GetValueVersion2")]
    public ActionResult<KeyValuePair<Guid, string>> GetValueVersion2()
    {
        return new KeyValuePair<Guid, string>(Guid.NewGuid(), "Version 2.0");
    }

    [HttpGet("v3", Name = "GetValueVersion3")]
    public ActionResult<KeyValuePair<Guid, string>> GetValueVersion3()
    {
        return new KeyValuePair<Guid, string>(Guid.NewGuid(), "all Versions allowed");
    }
}