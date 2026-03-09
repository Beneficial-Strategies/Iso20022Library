// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of capital.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a11fIdp-Ed-ak6NoX_4Aeg_502156633")]
[Description(@"Specifies the type of capital.")]
public enum CapitalTypeCode
{
    /// <summary>
    /// Approved capital.
    /// Encoded/decoded by serializers as &quot;APPD&quot;.
    /// </summary>
    [EnumMember(Value = "APPD")]
    [IsoId("_a11fItp-Ed-ak6NoX_4Aeg_545560156")]
    [Description(@"Approved capital.")]
    Approved,
    
    /// <summary>
    /// Issued voting rights.
    /// Encoded/decoded by serializers as &quot;ISVR&quot;.
    /// </summary>
    [EnumMember(Value = "ISVR")]
    [IsoId("_a11fI9p-Ed-ak6NoX_4Aeg_545563282")]
    [Description(@"Issued voting rights.")]
    IssuedVotingRights,
    
    /// <summary>
    /// Maximum amount of increase.
    /// Encoded/decoded by serializers as &quot;MXIN&quot;.
    /// </summary>
    [EnumMember(Value = "MXIN")]
    [IsoId("_a11fJNp-Ed-ak6NoX_4Aeg_546486650")]
    [Description(@"Maximum amount of increase.")]
    MaximumIncrease,
    
    /// <summary>
    /// Outstanding capital.
    /// Encoded/decoded by serializers as &quot;OUTS&quot;.
    /// </summary>
    [EnumMember(Value = "OUTS")]
    [IsoId("_a11fJdp-Ed-ak6NoX_4Aeg_547409678")]
    [Description(@"Outstanding capital.")]
    Outstanding,
    
    /// <summary>
    /// Redeemed capital.
    /// Encoded/decoded by serializers as &quot;REDE&quot;.
    /// </summary>
    [EnumMember(Value = "REDE")]
    [IsoId("_a11fJtp-Ed-ak6NoX_4Aeg_554798278")]
    [Description(@"Redeemed capital.")]
    Redeemed,
    
    /// <summary>
    /// Stated capital.
    /// Encoded/decoded by serializers as &quot;STCA&quot;.
    /// </summary>
    [EnumMember(Value = "STCA")]
    [IsoId("_a11fJ9p-Ed-ak6NoX_4Aeg_555721367")]
    [Description(@"Stated capital.")]
    StatedCapital,
    
    /// <summary>
    /// Issued reserve capital.
    /// Encoded/decoded by serializers as &quot;TRSO&quot;.
    /// </summary>
    [EnumMember(Value = "TRSO")]
    [IsoId("_a11fKNp-Ed-ak6NoX_4Aeg_556644310")]
    [Description(@"Issued reserve capital.")]
    TreasuryStock,
    
    /// <summary>
    /// Contingent capital.
    /// Encoded/decoded by serializers as &quot;UISS&quot;.
    /// </summary>
    [EnumMember(Value = "UISS")]
    [IsoId("_a11fKdp-Ed-ak6NoX_4Aeg_557567152")]
    [Description(@"Contingent capital.")]
    Unissued,
    
    /// <summary>
    /// Withdrawn capital.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_a1-pENp-Ed-ak6NoX_4Aeg_572344351")]
    [Description(@"Withdrawn capital.")]
    Withdrawn,
    
    /// <summary>
    /// Authorised capital.
    /// Encoded/decoded by serializers as &quot;AUTD&quot;.
    /// </summary>
    [EnumMember(Value = "AUTD")]
    [IsoId("_a1-pEdp-Ed-ak6NoX_4Aeg_573267379")]
    [Description(@"Authorised capital.")]
    Authorised,
    
    /// <summary>
    /// In circulation.
    /// Encoded/decoded by serializers as &quot;ICIR&quot;.
    /// </summary>
    [EnumMember(Value = "ICIR")]
    [IsoId("_a1-pEtp-Ed-ak6NoX_4Aeg_574190900")]
    [Description(@"In circulation.")]
    InCirculation,
    
    /// <summary>
    /// Issued capital.
    /// Encoded/decoded by serializers as &quot;ISUD&quot;.
    /// </summary>
    [EnumMember(Value = "ISUD")]
    [IsoId("_a1-pE9p-Ed-ak6NoX_4Aeg_576037973")]
    [Description(@"Issued capital.")]
    Issued,
    
    /// <summary>
    /// Issued reserve capital.
    /// Encoded/decoded by serializers as &quot;IRCA&quot;.
    /// </summary>
    [EnumMember(Value = "IRCA")]
    [IsoId("_a1-pFNp-Ed-ak6NoX_4Aeg_583426997")]
    [Description(@"Issued reserve capital.")]
    IssuedReserveCapital,
    
}
