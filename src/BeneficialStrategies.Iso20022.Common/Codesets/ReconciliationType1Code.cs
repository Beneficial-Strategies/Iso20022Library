// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of Reconciliation requested by the Sale to the POI.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7zFENxeEeioifFt1dhnJA")]
[Description(@"Type of Reconciliation requested by the Sale to the POI.")]
[DerivedFrom(typeof(ReconciliationTypeCode))]
public enum ReconciliationType1Code
{
    /// <summary>
    /// Reconciliation between the POI and one or several Acquirers only. There is no reconciliation between the Sale System and the POI System.
    /// Encoded/decoded by serializers as &quot;AREC&quot;.
    /// </summary>
    [EnumMember(Value = "AREC")]
    [IsoId("_czip0dxeEeioifFt1dhnJA")]
    [Description(@"Reconciliation between the POI and one or several Acquirers only. There is no reconciliation between the Sale System and the POI System.")]
    AcquirerReconciliation = ReconciliationTypeCode.AcquirerReconciliation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reconciliation and closure of the current period, with synchronisation of the reconciliation between the POI and Acquirers.
    /// Encoded/decoded by serializers as &quot;ASYN&quot;.
    /// </summary>
    [EnumMember(Value = "ASYN")]
    [IsoId("_c2J48dxeEeioifFt1dhnJA")]
    [Description(@"Reconciliation and closure of the current period, with synchronisation of the reconciliation between the POI and Acquirers.")]
    AcquirerSynchronisation = ReconciliationTypeCode.AcquirerSynchronisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request result of a previous reconciliation.
    /// Encoded/decoded by serializers as &quot;PREC&quot;.
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_c5ZaMdxeEeioifFt1dhnJA")]
    [Description(@"Request result of a previous reconciliation.")]
    PreviousReconciliation = ReconciliationTypeCode.PreviousReconciliation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reconciliation with closure of the current period, without	any Acquirers synchronisation.
    /// Encoded/decoded by serializers as &quot;SREC&quot;.
    /// </summary>
    [EnumMember(Value = "SREC")]
    [IsoId("_c9mkwdxeEeioifFt1dhnJA")]
    [Description(@"Reconciliation with closure of the current period, without	any Acquirers synchronisation.")]
    SaleReconciliation = ReconciliationTypeCode.SaleReconciliation, // same ordinal as derivation source for type conversions
    
}
