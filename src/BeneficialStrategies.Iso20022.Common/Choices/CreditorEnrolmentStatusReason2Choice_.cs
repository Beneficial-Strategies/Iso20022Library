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
    /// Specifies the reason for the status of a creditor enrolment.
    /// </summary>
    [KnownType(typeof(CreditorEnrolmentStatusReason2Choice.Code))]
    [KnownType(typeof(CreditorEnrolmentStatusReason2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CreditorEnrolmentStatusReason2Choice.Code),nameof(CreditorEnrolmentStatusReason2Choice.Code))]
    [JsonDerivedType(typeof(CreditorEnrolmentStatusReason2Choice.Proprietary),nameof(CreditorEnrolmentStatusReason2Choice.Proprietary))]
    #endif
    [IsoId("_fW_fY-IxEeqbls7Gk4-ckA")]
    [DisplayName("Creditor Enrolment Status Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CreditorEnrolmentStatusReason2Choice_
    #else
    public abstract partial class CreditorEnrolmentStatusReason2Choice_
    #endif
    {
    }
}
