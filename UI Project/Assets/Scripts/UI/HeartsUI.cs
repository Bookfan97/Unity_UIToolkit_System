using System;
using UnityEngine;
using UnityEngine.UIElements;
namespace UI
{
    public class HeartsUI : HealthUI
    {
        private VisualElement m_Hearts;
        public int health, maxHealth;
        
        protected override void OnEnable()
        {
            base.OnEnable();
            m_Hearts = m_UIDocument.rootVisualElement.Q("panel");
        }

        private void Update()
        {
            OnHealthChanged();
            OnMaxHealthChanged();
        }

        protected override void OnMaxHealthChanged()
        {
            for (int i = 0; i < m_Hearts.childCount; i++)
            {
                if (i < maxHealth)
                {
                    m_Hearts[i].style.visibility = Visibility.Visible;
                }
                else
                {
                    m_Hearts[i].style.visibility = Visibility.Hidden;
                }
            }
        }

        protected override void OnHealthChanged()
        {
            for (int i = 0; i < m_Hearts.childCount; i++)
            {
                if (i < health)
                {
                    m_Hearts[i][0].style.visibility = Visibility.Visible;
                }
                else
                {
                    m_Hearts[i][0].style.visibility = Visibility.Hidden;
                }
            }
        }
    }
}