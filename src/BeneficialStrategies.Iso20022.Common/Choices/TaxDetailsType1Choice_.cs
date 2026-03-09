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
    /// Choice of tax type.
    /// </summary>
    [KnownType(typeof(TaxDetailsType1Choice.Type))]
    [KnownType(typeof(TaxDetailsType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxDetailsType1Choice.Type),nameof(TaxDetailsType1Choice.Type))]
    [JsonDerivedType(typeof(TaxDetailsType1Choice.Proprietary),nameof(TaxDetailsType1Choice.Proprietary))]
    #endif
    [IsoId("_RfQKSNp-Ed-ak6NoX_4Aeg_-192931416")]
    [DisplayName("Tax Details Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxDetailsType1Choice_
    #else
    public abstract partial class TaxDetailsType1Choice_
    #endif
    {
    }
}
