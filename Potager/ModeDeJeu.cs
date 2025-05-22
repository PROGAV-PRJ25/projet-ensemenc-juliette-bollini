public class ModeDeJeux
{
    public bool ModeRapide { get; set; } = false;

    public void ChangerDeMode()
    {
        if (ModeRapide)
        {
            ModeRapide = false;
        }
        else
        {
            ModeRapide = true;
        }
    }
}
