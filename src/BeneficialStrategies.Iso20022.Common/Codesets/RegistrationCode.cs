// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Za7nZtp-Ed-ak6NoX_4Aeg_-740425248")]
[Description(
    @"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform."
)]
[Derivations(typeof(Registration1Code), typeof(Registration2Code))]
public enum RegistrationCode
{
    /// <summary>
    /// Hold the securities in street name. If there is a standing instruction in place to register on receipt, then this standing instruction is to be ignored.
    /// Encoded/decoded by serializers as &quot;NREG&quot;.
    /// </summary>
    [EnumMember(Value = "NREG")]
    [IsoId("_Za7nZ9p-Ed-ak6NoX_4Aeg_-740425246")]
    [Description(
        @"Hold the securities in street name. If there is a standing instruction in place to register on receipt, then this standing instruction is to be ignored."
    )]
    StreetName,

    /// <summary>
    /// Register on receipt. If there is a standing instruction in place to hold the securities in street name, then this standing instruction is to be ignored.
    /// Encoded/decoded by serializers as &quot;YREG&quot;.
    /// </summary>
    [EnumMember(Value = "YREG")]
    [IsoId("_Za7naNp-Ed-ak6NoX_4Aeg_-740425231")]
    [Description(
        @"Register on receipt. If there is a standing instruction in place to hold the securities in street name, then this standing instruction is to be ignored."
    )]
    Registered,

    /// <summary>
    /// You or your party set the instruction in a hold/frozen/preadvice mode.
    /// Encoded/decoded by serializers as &quot;PTYH&quot;.
    /// </summary>
    [EnumMember(Value = "PTYH")]
    [IsoId("_nAsOUPIrEd-dOvqmSLSz5g")]
    [Description(@"You or your party set the instruction in a hold/frozen/preadvice mode.")]
    PartyHold,

    /// <summary>
    /// Central securities depository sets the instruction in a hold/frozen/preadvice mode.
    /// Encoded/decoded by serializers as &quot;CSDH&quot;.
    /// </summary>
    [EnumMember(Value = "CSDH")]
    [IsoId("_ycMBQPIrEd-dOvqmSLSz5g")]
    [Description(
        @"Central securities depository sets the instruction in a hold/frozen/preadvice mode."
    )]
    CSDHold,

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditional delivery rules in the market infrastructure platform for conditional delivery.
    /// Encoded/decoded by serializers as &quot;CDEL&quot;.
    /// </summary>
    [EnumMember(Value = "CDEL")]
    [IsoId("_4bcN8PIrEd-dOvqmSLSz5g")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditional delivery rules in the market infrastructure platform for conditional delivery."
    )]
    ConditionalDelivery,

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.
    /// Encoded/decoded by serializers as &quot;CVAL&quot;.
    /// </summary>
    [EnumMember(Value = "CVAL")]
    [IsoId("_BmY6kPIsEd-dOvqmSLSz5g")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform."
    )]
    CSDValidation,
}
