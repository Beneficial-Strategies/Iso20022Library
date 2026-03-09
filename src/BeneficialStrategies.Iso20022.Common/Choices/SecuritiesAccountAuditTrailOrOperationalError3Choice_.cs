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
    /// Choice between the securities account reference data or an operational error.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountAuditTrailOrOperationalError3Choice.SecuritiesAccountAuditTrailReport))]
    [KnownType(typeof(SecuritiesAccountAuditTrailOrOperationalError3Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesAccountAuditTrailOrOperationalError3Choice.SecuritiesAccountAuditTrailReport),nameof(SecuritiesAccountAuditTrailOrOperationalError3Choice.SecuritiesAccountAuditTrailReport))]
    [JsonDerivedType(typeof(SecuritiesAccountAuditTrailOrOperationalError3Choice.OperationalError),nameof(SecuritiesAccountAuditTrailOrOperationalError3Choice.OperationalError))]
    #endif
    [IsoId("_AvnmYTp0Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Audit Trail Or Operational Error 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesAccountAuditTrailOrOperationalError3Choice_
    #else
    public abstract partial class SecuritiesAccountAuditTrailOrOperationalError3Choice_
    #endif
    {
    }
}
