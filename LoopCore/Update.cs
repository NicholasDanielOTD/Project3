using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Project3.Core;

public partial class Project3Main : Game
{
    private KeyboardState lastKstate;
    private MouseState lastMstate;

    protected void CheckInputs(GameTime gameTime)
    {
        var kstate = Keyboard.GetState();
        var mstate = Mouse.GetState();
        lastKstate = kstate;
        lastMstate = mstate;
    }

    protected bool KeyWasPressed(Keys key, KeyboardState kstate)
    {
        if (kstate.IsKeyUp(key) && this.lastKstate.IsKeyDown(key)) return true;
        return false;
    }

}
