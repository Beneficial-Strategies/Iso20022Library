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
    /// Choice of formats for the scope of a pension transfer.
    /// </summary>
    [KnownType(typeof(PensionTransferScope1Choice.Code))]
    [KnownType(typeof(PensionTransferScope1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PensionTransferScope1Choice.Code),nameof(PensionTransferScope1Choice.Code))]
    [JsonDerivedType(typeof(PensionTransferScope1Choice.Proprietary),nameof(PensionTransferScope1Choice.Proprietary))]
    #endif
    [IsoId("_REBa0E4YEeiQHa-q1Uephw")]
    [DisplayName("Pension Transfer Scope 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PensionTransferScope1Choice_
    #else
    public abstract partial class PensionTransferScope1Choice_
    #endif
    {
    }
}
