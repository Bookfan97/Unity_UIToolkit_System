using System;
using UnityEngine;
using UnityEngine.UIElements;
namespace UI
{
    [RequireComponent(typeof(UIDocument))]
    public class HealthUI : MonoBehaviour
    {
        protected UIDocument m_UIDocument;

        private void Awake()
        {
            m_UIDocument = GetComponent<UIDocument>();
        }
        
    }
}