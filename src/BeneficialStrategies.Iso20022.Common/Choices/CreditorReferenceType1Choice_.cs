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
    /// Specifies the type of document referred by the creditor.
    /// </summary>
    [KnownType(typeof(CreditorReferenceType1Choice.Code))]
    [KnownType(typeof(CreditorReferenceType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CreditorReferenceType1Choice.Code),nameof(CreditorReferenceType1Choice.Code))]
    [JsonDerivedType(typeof(CreditorReferenceType1Choice.Proprietary),nameof(CreditorReferenceType1Choice.Proprietary))]
    #endif
    [IsoId("_T3_jStp-Ed-ak6NoX_4Aeg_651436639")]
    [DisplayName("Creditor Reference Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CreditorReferenceType1Choice_
    #else
    public abstract partial class CreditorReferenceType1Choice_
    #endif
    {
    }
}
