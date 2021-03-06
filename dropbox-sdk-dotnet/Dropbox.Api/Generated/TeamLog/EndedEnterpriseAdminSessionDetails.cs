// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Ended enterprise admin session.</para>
    /// </summary>
    public class EndedEnterpriseAdminSessionDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<EndedEnterpriseAdminSessionDetails> Encoder = new EndedEnterpriseAdminSessionDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<EndedEnterpriseAdminSessionDetails> Decoder = new EndedEnterpriseAdminSessionDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="EndedEnterpriseAdminSessionDetails" /> class.</para>
        /// </summary>
        public EndedEnterpriseAdminSessionDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="EndedEnterpriseAdminSessionDetails" />.</para>
        /// </summary>
        private class EndedEnterpriseAdminSessionDetailsEncoder : enc.StructEncoder<EndedEnterpriseAdminSessionDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(EndedEnterpriseAdminSessionDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="EndedEnterpriseAdminSessionDetails" />.</para>
        /// </summary>
        private class EndedEnterpriseAdminSessionDetailsDecoder : enc.StructDecoder<EndedEnterpriseAdminSessionDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="EndedEnterpriseAdminSessionDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override EndedEnterpriseAdminSessionDetails Create()
            {
                return new EndedEnterpriseAdminSessionDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(EndedEnterpriseAdminSessionDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
