using Microsoft.VisualStudio.TestPlatform.Utilities;
using Smartphone.Models;

namespace SmartphoneTestes;


public class IphoneTestes
{
    private Iphone _iphone;

    public IphoneTestes()
    {
        this._iphone = new Iphone("11111111111", "modelo", "111111111111111", 1);
    }


    [Fact]
    public void DeveMudarNumeroPara8142002247()
    {
        this._iphone.Numero = "8142002247";

        Assert.Equal("8142002247", this._iphone.Numero);
    }


}
