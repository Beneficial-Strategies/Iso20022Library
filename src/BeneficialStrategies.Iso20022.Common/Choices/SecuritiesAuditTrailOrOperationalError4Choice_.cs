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
    /// Used to report between the securities reference data or an operational error.
    /// </summary>
    [KnownType(typeof(SecuritiesAuditTrailOrOperationalError4Choice.SecuritiesAuditTrailReport))]
    [KnownType(typeof(SecuritiesAuditTrailOrOperationalError4Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesAuditTrailOrOperationalError4Choice.SecuritiesAuditTrailReport),nameof(SecuritiesAuditTrailOrOperationalError4Choice.SecuritiesAuditTrailReport))]
    [JsonDerivedType(typeof(SecuritiesAuditTrailOrOperationalError4Choice.OperationalError),nameof(SecuritiesAuditTrailOrOperationalError4Choice.OperationalError))]
    #endif
    [IsoId("_PrBR8ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Securities Audit Trail Or Operational Error 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesAuditTrailOrOperationalError4Choice_
    #else
    public abstract partial class SecuritiesAuditTrailOrOperationalError4Choice_
    #endif
    {
    }
}
