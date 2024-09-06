using VisualBasicLib.Extensions;

namespace NETTesteMVVM.Extensions;

public class StringExtensionsTests
{
    [Test]
    public void ToFormNameTest()
    {
        var nomeFormularioPessoa = "Pessoa".ToFormName();
        var nomeFormularioEndereco = "Endereço".ToFormName();

        Assert.That(nomeFormularioPessoa, Is.EqualTo("frmPessoa"));
        Assert.That(nomeFormularioEndereco, Is.EqualTo("frmEndereco"));
        Assert.Pass();
    }
}
