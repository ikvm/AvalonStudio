﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvalonStudio.Controls.Standard.CodeEditor
{
    public class IntellisenseAssistantUserControl : UserControl
    {
        public IntellisenseAssistantUserControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}