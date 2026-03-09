// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Underlying reason for the payment transaction.||Usage: Purpose is used by the end-customers, i.e. initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [KnownType(typeof(Purpose1Choice.Code))]
    [KnownType(typeof(Purpose1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Purpose1Choice.Code),nameof(Purpose1Choice.Code))]
    [JsonDerivedType(typeof(Purpose1Choice.Proprietary),nameof(Purpose1Choice.Proprietary))]
    #endif
    [IsoId("_PrK9gNp-Ed-ak6NoX_4Aeg_-891374754")]
    [DisplayName("Purpose 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Purpose1Choice_
    #else
    public abstract partial class Purpose1Choice_
    #endif
    {
    }
}
