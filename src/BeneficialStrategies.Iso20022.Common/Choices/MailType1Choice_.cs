// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of mail.
    /// </summary>
    [KnownType(typeof(MailType1Choice.Code))]
    [KnownType(typeof(MailType1Choice.Proprietary))]
    [JsonDerivedType(typeof(MailType1Choice.Code),nameof(MailType1Choice.Code))]
    [JsonDerivedType(typeof(MailType1Choice.Proprietary),nameof(MailType1Choice.Proprietary))]
    [IsoId("_mQiA0CCXEeWJd9HF2tO7BA")]
    [DisplayName("Mail Type 1 Choice")]
    public abstract partial record MailType1Choice_
    {
    }
}
