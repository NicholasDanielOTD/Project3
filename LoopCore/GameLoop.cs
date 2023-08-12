using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project3.Core;

public partial class Project3Main : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Project3Main()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Assets";
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
