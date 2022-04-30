using System;
using UnityEngine;
using UnityEngine.UIElements;
namespace UI
{
    [RequireComponent(typeof(UIDocument))]
    public abstract class HealthUI : MonoBehaviour
    {
        protected UIDocument m_UIDocument;
        [SerializeField] protected GameObject m_Owner;

        protected void Awake()
        {
            m_UIDocument = GetComponent<UIDocument>();
        }

        protected virtual void OnEnable()
        {
            /*m_Damageable.healthChanged += OnHealthChanged;
            m_Damageable.maxHealthChanged += OnMaxHealthChanged;*/
        }

        protected virtual void OnDisable()
        {
            /*m_Damageable.healthChanged -= OnHealthChanged;
            m_Damageable.maxHealthChanged -= OnMaxHealthChanged;*/
        }

        protected abstract void OnMaxHealthChanged();

        protected abstract void OnHealthChanged();
    }
}