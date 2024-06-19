using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTE : MonoBehaviour
{
    public static QTE instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance  = this;
        }
        else
        {
            Destroy(this);
        }
    }

    [SerializeField] private RectTransform Background;
    private float width;
    [SerializeField] private RectTransform GreenZone;
    [SerializeField] private RectTransform Slider;
    private float SliderWidth;

    public void LaunchQTE(PlayerUnit PU, bool isAnAttack, float TimeEnd, float QTETimeStart, float Duration)
    {
        SliderWidth = Slider.rect.width;
        width = Background.rect.width;
        GreenZone.offsetMin = new Vector2(QTETimeStart / TimeEnd * width, 0);
        GreenZone.offsetMax = new Vector2((QTETimeStart + Duration - TimeEnd) / TimeEnd * width, 0);
        StartCoroutine(QTeCoroutine(PU, isAnAttack, TimeEnd, QTETimeStart, Duration));
    }

    private IEnumerator QTeCoroutine(PlayerUnit PU, bool isAnAttack, float TimeEnd, float QTETimeStart, float Duration)
    {
        float avancement = 0;
        float timer = 0;
        bool SpaceHasBeenClicked = false;
        while (timer < TimeEnd)
        {
            Slider.offsetMin = new Vector2(avancement * width - SliderWidth / 2, 0);
            Slider.offsetMax = new Vector2((avancement - 1) * width + SliderWidth / 2, 0);
            yield return null;
            timer += Time.deltaTime;
            avancement = timer / TimeEnd;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpaceHasBeenClicked = true;
                if (timer > QTETimeStart && timer < QTETimeStart + Duration)
                {
                    PU.QTE_Return(true, isAnAttack);
                }
                else
                {
                    PU.QTE_Return(false, isAnAttack);
                }
                break;
            }
        }
        if (!SpaceHasBeenClicked)
        {
            PU.QTE_Return(false, isAnAttack);
        }
    }
}
