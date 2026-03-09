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
    /// Specifies the reason for the update of securities.
    /// </summary>
    [KnownType(typeof(SecuritiesUpdateReason1Choice.Code))]
    [KnownType(typeof(SecuritiesUpdateReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesUpdateReason1Choice.Code),nameof(SecuritiesUpdateReason1Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesUpdateReason1Choice.Proprietary),nameof(SecuritiesUpdateReason1Choice.Proprietary))]
    #endif
    [IsoId("_20ciUJI7EeuAlLVx8pyt3w")]
    [DisplayName("Securities Update Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesUpdateReason1Choice_
    #else
    public abstract partial class SecuritiesUpdateReason1Choice_
    #endif
    {
    }
}
