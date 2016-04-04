using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLearning
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class rss
{

    private rssChannel channelField;

    private decimal versionField;

    /// <remarks/>
    public rssChannel channel
    {
        get
        {
            return this.channelField;
        }
        set
        {
            this.channelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rssChannel
{

    private object titleField;

    private string linkField;

    private string generatorField;

    private string languageField;

    private ushort copyrightField;

    private rssChannelItem[] itemField;

    /// <remarks/>
    public object title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    /// <remarks/>
    public string link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }

    /// <remarks/>
    public string generator
    {
        get
        {
            return this.generatorField;
        }
        set
        {
            this.generatorField = value;
        }
    }

    /// <remarks/>
    public string language
    {
        get
        {
            return this.languageField;
        }
        set
        {
            this.languageField = value;
        }
    }

    /// <remarks/>
    public ushort copyright
    {
        get
        {
            return this.copyrightField;
        }
        set
        {
            this.copyrightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("item")]
    public rssChannelItem[] item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rssChannelItem
{

    private string titleField;

    private string linkField;

    private string pubDateField;

    private string encodedField;

    /// <remarks/>
    public string title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    /// <remarks/>
    public string link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }

    /// <remarks/>
    public string pubDate
    {
        get
        {
            return this.pubDateField;
        }
        set
        {
            this.pubDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/rss/1.0/modules/content/")]
    public string encoded
    {
        get
        {
            return this.encodedField;
        }
        set
        {
            this.encodedField = value;
        }
    }
}


{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
