// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of data set that is matched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayQmsNp-Ed-ak6NoX_4Aeg_952185864")]
[Description(@"Specifies the type of data set that is matched.")]
[Derivations(typeof(DataSetType1Code),typeof(DataSetType2Code))]
public enum DataSetTypeCode
{
    /// <summary>
    /// Data set is a baseline.
    /// Encoded/decoded by serializers as &quot;BASE&quot;.
    /// </summary>
    [EnumMember(Value = "BASE")]
    [IsoId("_ayQmsdp-Ed-ak6NoX_4Aeg_1355767413")]
    [Description(@"Data set is a baseline.")]
    Baseline,
    
    /// <summary>
    /// Data set is a transport data set.
    /// Encoded/decoded by serializers as &quot;TRDS&quot;.
    /// </summary>
    [EnumMember(Value = "TRDS")]
    [IsoId("_ayQmstp-Ed-ak6NoX_4Aeg_1425954834")]
    [Description(@"Data set is a transport data set.")]
    TransportDataSet,
    
    /// <summary>
    /// Data set is a commercial data set.
    /// Encoded/decoded by serializers as &quot;CODS&quot;.
    /// </summary>
    [EnumMember(Value = "CODS")]
    [IsoId("_ayQms9p-Ed-ak6NoX_4Aeg_1497987506")]
    [Description(@"Data set is a commercial data set.")]
    CommercialDataSet,
    
    /// <summary>
    /// Data set is an insurance data set.
    /// Encoded/decoded by serializers as &quot;INDS&quot;.
    /// </summary>
    [EnumMember(Value = "INDS")]
    [IsoId("_ayQmtNp-Ed-ak6NoX_4Aeg_1136593278")]
    [Description(@"Data set is an insurance data set.")]
    InsuranceDataSet,
    
    /// <summary>
    /// Data set is a certificate data set.
    /// Encoded/decoded by serializers as &quot;CEDS&quot;.
    /// </summary>
    [EnumMember(Value = "CEDS")]
    [IsoId("_ayQmtdp-Ed-ak6NoX_4Aeg_1136593309")]
    [Description(@"Data set is a certificate data set.")]
    CertificateDataSet,
    
    /// <summary>
    /// Data set is an other special certificate data set.
    /// Encoded/decoded by serializers as &quot;OCDS&quot;.
    /// </summary>
    [EnumMember(Value = "OCDS")]
    [IsoId("_ayQmttp-Ed-ak6NoX_4Aeg_1136593339")]
    [Description(@"Data set is an other special certificate data set.")]
    OtherCertificateDataSet,
    
}
