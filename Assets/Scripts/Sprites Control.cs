using UnityEngine;

public class CharacterCustomization : MonoBehaviour
{
    public SpriteRenderer faceRenderer;
    public SpriteRenderer hairRenderer;
    public SpriteRenderer eyesRenderer;

    public Sprite[] hairSprites;
    public Sprite[] eyeSprites;

    private int hairColorIndex = 0;
    private int eyeColorIndex = 0;

    void Start()
    {
        UpdateCharacter();
    }

    public void NextHairColor()
    {
        hairColorIndex = (hairColorIndex + 1) % hairSprites.Length;
        UpdateCharacter();
    }

    public void PreviousHairColor()
    {
        hairColorIndex = (hairColorIndex - 1 + hairSprites.Length) % hairSprites.Length;
        UpdateCharacter();
    }

    public void NextEyeColor()
    {
        eyeColorIndex = (eyeColorIndex + 1) % eyeSprites.Length;
        UpdateCharacter();
    }

    public void PreviousEyeColor()
    {
        eyeColorIndex = (eyeColorIndex - 1 + eyeSprites.Length) % eyeSprites.Length;
        UpdateCharacter();
    }

    private void UpdateCharacter()
    {
        // Update the character's hair and eye color
        hairRenderer.sprite = hairSprites[hairColorIndex];
        eyesRenderer.sprite = eyeSprites[eyeColorIndex];
    }
}


/*using UnityEngine;

public class CharacterCustomization : MonoBehaviour
{
    public SpriteRenderer characterRenderer;

    public Sprite faceSprite;  // Face sprite (constant)
    public Sprite[] hairSprites; // Array of hair sprites
    public Sprite[] eyeSprites;  // Array of eye sprites

    private int hairColorIndex = 0;
    private int eyeColorIndex = 0;

    // Called when the script starts
    void Start()
    {
        // Initialize character appearance
        UpdateCharacter();
    }

    public void NextHairColor()
    {
        hairColorIndex = (hairColorIndex + 1) % hairSprites.Length;
        UpdateCharacter();
    }

    public void PreviousHairColor()
    {
        hairColorIndex = (hairColorIndex - 1 + hairSprites.Length) % hairSprites.Length;
        UpdateCharacter();
    }

    public void NextEyeColor()
    {
        eyeColorIndex = (eyeColorIndex + 1) % eyeSprites.Length;
        UpdateCharacter();
    }

    public void PreviousEyeColor()
    {
        eyeColorIndex = (eyeColorIndex - 1 + eyeSprites.Length) % eyeSprites.Length;
        UpdateCharacter();
    }

    private void UpdateCharacter()
    {
        // Combine face, hair, and eyes into a composite sprite
        Sprite compositeSprite = CombineSprites(faceSprite, hairSprites[hairColorIndex], eyeSprites[eyeColorIndex]);

        // Update the character's appearance
        characterRenderer.sprite = compositeSprite;
    }

    // Combine the face, hair, and eyes into a single sprite
    private Sprite CombineSprites(Sprite face, Sprite hair, Sprite eyes)
    {
        // Get the textures from the sprites
        Texture2D faceTexture = face.texture;
        Texture2D hairTexture = hair.texture;
        Texture2D eyesTexture = eyes.texture;

        // Ensure the textures are marked as readable
        faceTexture.wrapMode = TextureWrapMode.Clamp;
        hairTexture.wrapMode = TextureWrapMode.Clamp;
        eyesTexture.wrapMode = TextureWrapMode.Clamp;

        // Create a new texture to combine the sprites
        Texture2D combinedTexture = new Texture2D(faceTexture.width, faceTexture.height);
        combinedTexture.filterMode = FilterMode.Point; // Maintain pixelated look

        // Combine the textures by applying each one
        combinedTexture.SetPixels(faceTexture.GetPixels());
        combinedTexture.SetPixels(hairTexture.GetPixels());
        combinedTexture.SetPixels(eyesTexture.GetPixels());

        // Apply changes and create a new sprite from the combined texture
        combinedTexture.Apply();

        return Sprite.Create(combinedTexture, new Rect(0, 0, combinedTexture.width, combinedTexture.height), new Vector2(0.5f, 0.5f));
    }

}
*/