using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay;
    private int _counter = 0;
    private Coroutine _coroutine;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_coroutine == null)
            {
                _coroutine = StartCoroutine(ChangeText());
            }
            else
            {
                StopCoroutine(_coroutine);
                _coroutine = null;
            }
        }
    }

    private IEnumerator ChangeText()
    {
        while (enabled)
        {
            _counter++;
            _text.SetText(_counter.ToString());
            yield return new WaitForSeconds(_delay);
        }
    }
}
