// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the balance type, as published in an external balance type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Nl6j4IakEeeUws0ZryHQ2w")]
[Description(@"Specifies the balance type, as published in an external balance type code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalBalanceType1Code))]
public enum ExternalBalanceTypeCode
{
    /// <summary>
    /// Closing balance of amount of money that is at the disposal of the account owner on the date specified. 
    /// Encoded/decoded by serializers as &quot;CLAV&quot;.
    /// </summary>
    [EnumMember(Value = "CLAV")]
    [IsoId("_ua6dY_RYEeuLhpyIdtJzwg")]
    [Description(@"Closing balance of amount of money that is at the disposal of the account owner on the date specified. ")]
    ClosingAvailable,
    
    /// <summary>
    /// Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period. 
    /// Encoded/decoded by serializers as &quot;CLBD&quot;.
    /// </summary>
    [EnumMember(Value = "CLBD")]
    [IsoId("_ua6dZvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period. ")]
    ClosingBooked,
    
    /// <summary>
    /// Forward available balance of money that is at the disposal of the account owner on the date specified. 
    /// Encoded/decoded by serializers as &quot;FWAV&quot;.
    /// </summary>
    [EnumMember(Value = "FWAV")]
    [IsoId("_ua6dafRYEeuLhpyIdtJzwg")]
    [Description(@"Forward available balance of money that is at the disposal of the account owner on the date specified. ")]
    ForwardAvailable,
    
    /// <summary>
    /// Balance for informational purposes. 
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_ua6dbPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance for informational purposes. ")]
    Information,
    
    /// <summary>
    /// Available balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified. 
    /// Encoded/decoded by serializers as &quot;ITAV&quot;.
    /// </summary>
    [EnumMember(Value = "ITAV")]
    [IsoId("_ubDnUPRYEeuLhpyIdtJzwg")]
    [Description(@"Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified. ")]
    InterimAvailable,
    
    /// <summary>
    /// Balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified. 
    /// Encoded/decoded by serializers as &quot;ITBD&quot;.
    /// </summary>
    [EnumMember(Value = "ITBD")]
    [IsoId("_ubDnU_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified. ")]
    InterimBooked,
    
    /// <summary>
    /// Opening balance of amount of money that is at the disposal of the account owner on the date specified. 
    /// Encoded/decoded by serializers as &quot;OPAV&quot;.
    /// </summary>
    [EnumMember(Value = "OPAV")]
    [IsoId("_ubDnVvRYEeuLhpyIdtJzwg")]
    [Description(@"Opening balance of amount of money that is at the disposal of the account owner on the date specified. ")]
    OpeningAvailable,
    
    /// <summary>
    /// Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report. 
    /// Encoded/decoded by serializers as &quot;OPBD&quot;.
    /// </summary>
    [EnumMember(Value = "OPBD")]
    [IsoId("_ubDnWfRYEeuLhpyIdtJzwg")]
    [Description(@"Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report. ")]
    OpeningBooked,
    
    /// <summary>
    /// Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance.|Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.
    /// Encoded/decoded by serializers as &quot;PRCD&quot;.
    /// </summary>
    [EnumMember(Value = "PRCD")]
    [IsoId("_ubNYUPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance.|Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.")]
    PreviouslyClosedBooked,
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted. 
    /// Encoded/decoded by serializers as &quot;XPCD&quot;.
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_ubNYU_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted. ")]
    Expected,
    
}
