using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MyGame;

public partial class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

    }

    protected override void Update(GameTime gameTime)
    {
        CheckInputs(gameTime);


        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        Color backgroundColor = Color.Beige;
        GraphicsDevice.Clear(backgroundColor);
        _spriteBatch.Begin();
        
        _spriteBatch.End();
        base.Draw(gameTime);
    }

}
