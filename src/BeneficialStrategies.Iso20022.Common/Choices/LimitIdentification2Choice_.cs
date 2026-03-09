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
    /// Limit details of one particular limit set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(LimitIdentification2Choice.Current))]
    [KnownType(typeof(LimitIdentification2Choice.Default))]
    [KnownType(typeof(LimitIdentification2Choice.AllCurrent))]
    [KnownType(typeof(LimitIdentification2Choice.AllDefault))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LimitIdentification2Choice.Current),nameof(LimitIdentification2Choice.Current))]
    [JsonDerivedType(typeof(LimitIdentification2Choice.Default),nameof(LimitIdentification2Choice.Default))]
    [JsonDerivedType(typeof(LimitIdentification2Choice.AllCurrent),nameof(LimitIdentification2Choice.AllCurrent))]
    [JsonDerivedType(typeof(LimitIdentification2Choice.AllDefault),nameof(LimitIdentification2Choice.AllDefault))]
    #endif
    [IsoId("_A_hEt24-EeiU9cctagi5ow")]
    [DisplayName("Limit Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LimitIdentification2Choice_
    #else
    public abstract partial class LimitIdentification2Choice_
    #endif
    {
    }
}
