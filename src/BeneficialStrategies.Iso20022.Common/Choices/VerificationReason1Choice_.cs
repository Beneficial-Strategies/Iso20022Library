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
    /// Specifies the reason why the verified identification information is incorrect.
    /// </summary>
    [KnownType(typeof(VerificationReason1Choice.Code))]
    [KnownType(typeof(VerificationReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(VerificationReason1Choice.Code),nameof(VerificationReason1Choice.Code))]
    [JsonDerivedType(typeof(VerificationReason1Choice.Proprietary),nameof(VerificationReason1Choice.Proprietary))]
    #endif
    [IsoId("_Qo3U1Np-Ed-ak6NoX_4Aeg_-449981895")]
    [DisplayName("Verification Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record VerificationReason1Choice_
    #else
    public abstract partial class VerificationReason1Choice_
    #endif
    {
    }
}
