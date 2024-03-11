using System.Windows.Media;

namespace Protect_yourself.script
{
    internal class Other
    {
        //MediaPlayer mediaPlayer = new MediaPlayer();
        
        public bool isEnabled;
        public MediaPlayer audio = new MediaPlayer();
        public void reset() 
        {
            isEnabled= true;
        }

        public void play(string path)
        {
            audio.Open(new System.Uri(path));
            audio.Play();
        }
        public void stop()
        {
            audio.Stop();
        }

       
    }
}
