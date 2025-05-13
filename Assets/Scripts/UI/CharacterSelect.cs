using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public Material characterMaterial; //ĳ���� ��Ƽ����(���� ��)
    public List<Texture2D> textures;   //��Ų ���

    public Renderer SelectCharacter;   //ȭ�鿡�� ���̴� ĳ����
    public Button LButton, RButton, CButton; //��ư ����(������ ��ũ��Ʈ)

    private int idx = 0; //����Ʈ�� �ε��� ǥ��

    private void Start()
    {
        Apply(idx);

        LButton.onClick.AddListener(OnLButtonEnter);
        RButton.onClick.AddListener(OnRButtonEnter);
        CButton.onClick.AddListener(OnCButtonEnter);
    }

    public void OnLButtonEnter()
    {
        if(idx > 0)
        {
            idx--;
            Apply(idx);
            OnLRButtonExit();
        }
        else
        {
            Debug.Log("���� ��Ż");
        }
    }

    private void OnLRButtonExit()
    {
        LButton.interactable = idx > 0;
        RButton.interactable = idx < textures.Count - 1;
    }

    public void OnRButtonEnter()
    {
        if (idx < textures.Count-1)
        {
            idx++;
            Apply(idx);
            OnLRButtonExit();
        }
        else
        {
            Debug.Log("���� ��Ż");
        }
    }

    public void OnCButtonEnter()
    {
        characterMaterial.SetTexture("_BaseMap", textures[idx]);
        SceneManager.LoadScene("GameScene");
    }

    private void Apply(int index)
    {
        SelectCharacter.material.SetTexture("_BaseMap", textures[index]);
    }

}
