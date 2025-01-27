﻿using QQChannelBot.Models;

namespace QQChannelBot.MsgHelper
{
    /// <summary>
    /// Embed消息对象
    /// </summary>
    public class MsgEmbed
    {
        /// <summary>
        /// 构建Embed消息
        /// <code>
        /// 示例:
        /// |{
        /// |    "content": "普通消息内容",
        /// |    "embed": {
        /// |        "title": "标题",
        /// |        "prompt": "消息通知",
        /// |        "thumbnail": { "url": "缩略图url"},
        /// |        "fields": [
        /// |            { "name": "第一行内容"},
        /// |            { "name": "第二行内容"},
        /// |            { "name": "第三行内容"}
        /// |        ]
        /// |    }
        /// |    "msg_id": "要回复的消息Id"
        /// |}
        /// </code>
        /// <para>详情查阅QQ机器人文档 <see href="https://bot.q.qq.com/wiki/develop/api/openapi/message/template/embed_message.html">embed消息</see></para>
        /// </summary>
        /// <param name="replyMsgId">要回复的消息id, 空字符串表示发送主动消息</param>
        public MsgEmbed(string replyMsgId = "")
        {
            ReplyMsgId = replyMsgId;
        }

        /// <summary>
        /// 返回构建完成的Embed消息对象
        /// </summary>
        public MessageToCreate Body
        {
            get => new()
            {
                Content = Content,
                Embed = new()
                {
                    Title = this.Title,
                    Prompt = this.Prompt,
                    Thumbnail = new() { Url = this.Thumbnail },
                    Fields = Fields.ToArray()
                },
                MsgId = ReplyMsgId
            };
        }

        /// <summary>
        /// 普通消息内容
        /// </summary>
        public string? Content { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// 消息通知
        /// </summary>
        public string? Prompt { get; set; }

        /// <summary>
        /// 缩略图url
        /// </summary>
        public string? Thumbnail { get; set; }

        /// <summary>
        /// 消息时间轴
        /// </summary>
        public List<MessageEmbedField> Fields = new();

        /// <summary>
        /// 要回复的消息id
        /// </summary>
        public string? ReplyMsgId { get; set; }
    }
}
