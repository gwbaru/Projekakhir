using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stealth : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool isStealth = false;

    void Start()
    {
        // Dapatkan komponen SpriteRenderer
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Skill1();
    }

    private void Skill1()
    {
        // Periksa input pengguna atau kondisi lainnya untuk mengaktifkan/dinonaktifkan stealth
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isStealth = !isStealth;

            // Panggil fungsi untuk mengubah keadaan stealth
            SetStealth(isStealth);
        }
    }

    void SetStealth(bool stealth)
    {
        // Ubah alpha pada material sprite renderer untuk membuat karakter transparan atau tidak
        Color currentColor = spriteRenderer.color;

        if (stealth)
        {
            // Jika stealth diaktifkan, atur alpha ke nilai yang lebih rendah (misalnya 0.5f)
            currentColor.a = 0.2f;
        }
        else
        {
            // Jika stealth dinonaktifkan, atur alpha ke nilai penuh (misalnya 1.0f)
            currentColor.a = 1.0f;
        }

        spriteRenderer.color = currentColor;
    }
}
