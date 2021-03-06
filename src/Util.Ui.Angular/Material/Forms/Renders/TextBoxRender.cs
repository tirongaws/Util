﻿using Util.Ui.Builders;
using Util.Ui.Material.Forms.Builders;
using Util.Ui.Material.Forms.Configs;
using Util.Ui.Renders;

namespace Util.Ui.Material.Forms.Renders {
    /// <summary>
    /// 文本框渲染器
    /// </summary>
    public class TextBoxRender : RenderBase<FormFieldBuilder, TextBoxConfig> {
        /// <summary>
        /// 初始化文本框渲染器
        /// </summary>
        /// <param name="config">文本框配置</param>
        public TextBoxRender( TextBoxConfig config ) : base( config ) {
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override FormFieldBuilder GetTagBuilder() {
            return new FormFieldBuilder();
        }

        /// <summary>
        /// 渲染
        /// </summary>
        /// <param name="builder">标签生成器</param>
        /// <param name="config">组件配置</param>
        protected override void Render( FormFieldBuilder builder, TextBoxConfig config ) {
            base.Render( builder, config );
            builder.SetChild( GetInputBuilder( config ) );
        }

        /// <summary>
        /// 获取输入控件生成器
        /// </summary>
        private TagBuilder GetInputBuilder( TextBoxConfig config ) {
            var builder = new InputBuilder().SetText();
            builder.Attribute( "placeholder", config.Placeholder );
            builder.Attribute( "value", config.Value );
            builder.Attribute( "type", config.Type );
            return builder;
        }
    }
}
