// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of event processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CorporateActionEventProcessingType2Code")]
[Description(@"Specifies the type of event processing.")]
[DerivedFrom(typeof(CorporateActionEventProcessingTypeCode))]
public enum CorporateActionEventProcessingType2Code
{
    /// <summary>
    /// Holder of the relevant security on a certain date, for example, the record date, will receive a benefit without giving up the underlying security.
    /// Encoded/decoded by serializers as &quot;DISN&quot;.
    /// </summary>
    [EnumMember(Value = "DISN")]
    [IsoId("_CorporateActionEventProcessingType2Code_Distribution")]
    [Description(@"Holder of the relevant security on a certain date, for example, the record date, will receive a benefit without giving up the underlying security.")]
    Distribution = CorporateActionEventProcessingTypeCode.Distribution,

    /// <summary>
    /// No debit or credit of resources.
    /// Encoded/decoded by serializers as &quot;GENL&quot;.
    /// </summary>
    [EnumMember(Value = "GENL")]
    [IsoId("_CorporateActionEventProcessingType2Code_General")]
    [Description(@"No debit or credit of resources.")]
    General = CorporateActionEventProcessingTypeCode.General,

    /// <summary>
    /// Indicates that the announcement is for a redemption of securities for events including full and partial calls, maturities partial prerefunding and partial defeasance events.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_CorporateActionEventProcessingType2Code_Redemption")]
    [Description(@"Indicates that the announcement is for a redemption of securities for events including full and partial calls, maturities partial prerefunding and partial defeasance events.")]
    Redemption,

    /// <summary>
    /// Underlying security will be debited and may be replaced by another resource (or resources).
    /// Encoded/decoded by serializers as &quot;REOR&quot;.
    /// </summary>
    [EnumMember(Value = "REOR")]
    [IsoId("_CorporateActionEventProcessingType2Code_Reorganisation")]
    [Description(@"Underlying security will be debited and may be replaced by another resource (or resources).")]
    Reorganisation = CorporateActionEventProcessingTypeCode.Reorganisation,

}
