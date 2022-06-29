namespace Dotgem.Text;

public class Spacing
{
    private IFiller? _filler;
    public IFiller Filler => _filler ??= new Filler();

    private ICharCounter? _charCounter;
    public ICharCounter CharCounter => _charCounter ??= new CharCounter();

    public Spacing()
    {

    }

    public Spacing(IFiller filler, ICharCounter charCounter)
    {
        _filler = filler;
        _charCounter = charCounter;
    }
}
