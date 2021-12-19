﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQChannelBot.Models;

namespace QQChannelBot.MsgHelper
{
    public class MsgNormal
    {
        /// <summary>
        /// 构建普通消息
        /// </summary>
        /// <param name="replyMsgId">要回复的消息id, 空字符串表示发送主动消息</param>
        public MsgNormal(string replyMsgId)
        {
            ReplyMsgId = replyMsgId;
        }

        /// <summary>
        /// 构建完成的普通消息体
        /// </summary>
        public MessageToCreate Body
        {
            get => new()
            {
                Content = Content,
                MsgId = ReplyMsgId
            };
        }

        /// <summary>
        /// 普通消息内容
        /// </summary>
        public string? Content { get; set; }

        /// <summary>
        /// 要回复的消息id
        /// </summary>
        public string? ReplyMsgId { get; set; }
    }
}