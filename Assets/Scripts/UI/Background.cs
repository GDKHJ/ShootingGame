using UnityEngine;
//��Ƽ������ offset�� �����ؼ� ����� ��ũ�ѵǴ�
//������ �۾��� �����Ϸ��� �մϴ�.

public class Background : MonoBehaviour
{
    public Material backgroundMaterial;
    public Texture2D newTexture;

    public float speed = 0.2f;

    private void Start()
    {
        
    }

    private void Update()
    {
        //���� �� ����
        Vector2 dir = Vector2.up;

        backgroundMaterial.mainTextureOffset += dir * speed * Time.deltaTime;
    }

    [ContextMenu("�ؽ�ó ����")]
    public void TextureChange()
    {
        backgroundMaterial.SetTexture("_BaseMap", newTexture);
        //_BaseMap�� Universal Render PipeLine(URP)���� ����ϴ� ���̴� �Ӽ��� �̸�

        //Built in ȯ��(���� ���)�� ��쿡�� ������ ���� �ڵ带 �ۼ��մϴ�.
        //Standard Shader(�⺻ ���̴�)���� �����ϰ� �ִ� �⺻ �ؽ�ó�� �̸��Դϴ�.
        //backgroundMaterial.SetTexture("_MainTex", newTexture);
    }

}
