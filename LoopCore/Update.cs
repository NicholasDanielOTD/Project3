using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MyGame;

public partial class Game1 : Game
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
