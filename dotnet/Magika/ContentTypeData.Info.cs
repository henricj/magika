using System.Collections.Frozen;

namespace Magika;

public static partial class ContentTypeData
{
    private static readonly FrozenDictionary<ContentType, ContentTypeInfo> Info =
        FrozenDictionary.Create(
            new KeyValuePair<ContentType, ContentTypeInfo>(ContentType._3gp, new()
            {
                Label = "3gp",
                MimeType = "video/3gpp",
                Group = "video",
                Description = "3GPP multimedia file",
                Extensions = ["3gp"],
                IsText = false
            }),
            new(ContentType.Ace, new()
            {
                Label = "ace",
                MimeType = "application/x-ace-compressed",
                Group = "archive",
                Description = "ACE archive",
                Extensions = ["ace"],
                IsText = false
            }),
            new(ContentType.Ai, new()
            {
                Label = "ai",
                MimeType = "application/pdf",
                Group = "document",
                Description = "Adobe Illustrator Artwork",
                Extensions = ["ai"],
                IsText = false
            }),
            new(ContentType.Aidl, new()
            {
                Label = "aidl",
                MimeType = "text/plain",
                Group = "unknown",
                Description = "Android Interface Definition Language",
                Extensions = ["aidl"],
                IsText = true
            }),
            new(ContentType.Apk, new()
            {
                Label = "apk",
                MimeType = "application/vnd.android.package-archive",
                Group = "executable",
                Description = "Android package",
                Extensions = ["apk"],
                IsText = false
            }),
            new(ContentType.Applebplist, new()
            {
                Label = "applebplist",
                MimeType = "application/x-bplist",
                Group = "application",
                Description = "Apple binary property list",
                Extensions = ["bplist", "plist"],
                IsText = false
            }),
            new(ContentType.Appleplist, new()
            {
                Label = "appleplist",
                MimeType = "application/x-plist",
                Group = "application",
                Description = "Apple property list",
                Extensions = ["plist"],
                IsText = true
            }),
            new(ContentType.Asm, new()
            {
                Label = "asm",
                MimeType = "text/x-asm",
                Group = "code",
                Description = "Assembly",
                Extensions = ["s", "S", "asm"],
                IsText = true
            }),
            new(ContentType.Asp, new()
            {
                Label = "asp",
                MimeType = "text/html",
                Group = "code",
                Description = "ASP source",
                Extensions = ["aspx", "asp"],
                IsText = true
            }),
            new(ContentType.Autohotkey, new()
            {
                Label = "autohotkey",
                MimeType = "text/plain",
                Group = "code",
                Description = "AutoHotKey script",
                Extensions = [],
                IsText = true
            }),
            new(ContentType.Autoit, new()
            {
                Label = "autoit",
                MimeType = "text/plain",
                Group = "code",
                Description = "AutoIt script",
                Extensions = ["au3"],
                IsText = true
            }),
            new(ContentType.Awk, new()
            {
                Label = "awk",
                MimeType = "text/plain",
                Group = "code",
                Description = "Awk",
                Extensions = ["awk"],
                IsText = true
            }),
            new(ContentType.Batch, new()
            {
                Label = "batch",
                MimeType = "text/x-msdos-batch",
                Group = "code",
                Description = "DOS batch file",
                Extensions = ["bat"],
                IsText = true
            }),
            new(ContentType.Bazel, new()
            {
                Label = "bazel",
                MimeType = "text/plain",
                Group = "code",
                Description = "Bazel build file",
                Extensions = ["bzl"],
                IsText = true
            }),
            new(ContentType.Bib, new()
            {
                Label = "bib",
                MimeType = "text/x-bibtex",
                Group = "text",
                Description = "BibTeX",
                Extensions = ["bib"],
                IsText = true
            }),
            new(ContentType.Bmp, new()
            {
                Label = "bmp",
                MimeType = "image/bmp",
                Group = "image",
                Description = "BMP image data",
                Extensions = ["bmp"],
                IsText = false
            }),
            new(ContentType.Bzip, new()
            {
                Label = "bzip",
                MimeType = "application/x-bzip2",
                Group = "archive",
                Description = "bzip2 compressed data",
                Extensions = ["bz2", "tbz2", "tar.bz2"],
                IsText = false
            }),
            new(ContentType.C, new()
            {
                Label = "c",
                MimeType = "text/x-c",
                Group = "code",
                Description = "C source",
                Extensions = ["c"],
                IsText = true
            }),
            new(ContentType.Cab, new()
            {
                Label = "cab",
                MimeType = "application/vnd.ms-cab-compressed",
                Group = "archive",
                Description = "Microsoft Cabinet archive data",
                Extensions = ["cab"],
                IsText = false
            }),
            new(ContentType.Cat, new()
            {
                Label = "cat",
                MimeType = "application/octet-stream",
                Group = "application",
                Description = "Windows Catalog file",
                Extensions = ["cat"],
                IsText = false
            }),
            new(ContentType.Chm, new()
            {
                Label = "chm",
                MimeType = "application/chm",
                Group = "application",
                Description = "MS Windows HtmlHelp Data",
                Extensions = ["chm"],
                IsText = false
            }),
            new(ContentType.Clojure, new()
            {
                Label = "clojure",
                MimeType = "text/x-clojure",
                Group = "code",
                Description = "Clojure",
                Extensions = ["clj", "cljs", "cljc", "cljr"],
                IsText = true
            }),
            new(ContentType.Cmake, new()
            {
                Label = "cmake",
                MimeType = "text/x-cmake",
                Group = "code",
                Description = "CMake build file",
                Extensions = ["cmake"],
                IsText = true
            }),
            new(ContentType.Cobol, new()
            {
                Label = "cobol",
                MimeType = "text/x-cobol",
                Group = "code",
                Description = "Cobol",
                Extensions = ["cbl", "cob", "cpy", "CBL", "COB", "CPY"],
                IsText = true
            }),
            new(ContentType.Coff, new()
            {
                Label = "coff",
                MimeType = "application/x-coff",
                Group = "executable",
                Description = "Intel 80386 COFF",
                Extensions = ["obj", "o"],
                IsText = false
            }),
            new(ContentType.Coffeescript, new()
            {
                Label = "coffeescript",
                MimeType = "text/coffeescript",
                Group = "code",
                Description = "CoffeeScript",
                Extensions = ["coffee"],
                IsText = true
            }),
            new(ContentType.Cpp, new()
            {
                Label = "cpp",
                MimeType = "text/x-c",
                Group = "code",
                Description = "C++ source",
                Extensions = ["cc", "cpp", "cxx", "c++", "cppm", "ixx"],
                IsText = true
            }),
            new(ContentType.Crt, new()
            {
                Label = "crt",
                MimeType = "application/x-x509-ca-cert",
                Group = "text",
                Description = "Certificates (binary format)",
                Extensions = ["der", "cer", "crt"],
                IsText = false
            }),
            new(ContentType.Crx, new()
            {
                Label = "crx",
                MimeType = "application/x-chrome-extension",
                Group = "executable",
                Description = "Google Chrome extension",
                Extensions = ["crx"],
                IsText = false
            }),
            new(ContentType.Cs, new()
            {
                Label = "cs",
                MimeType = "text/plain",
                Group = "code",
                Description = "C# source",
                Extensions = ["cs", "csx"],
                IsText = true
            }),
            new(ContentType.Csproj, new()
            {
                Label = "csproj",
                MimeType = "text/plain",
                Group = "code",
                Description = ".NET project config",
                Extensions = ["csproj"],
                IsText = true
            }),
            new(ContentType.Css, new()
            {
                Label = "css",
                MimeType = "text/css",
                Group = "code",
                Description = "CSS source",
                Extensions = ["css"],
                IsText = true
            }),
            new(ContentType.Csv, new()
            {
                Label = "csv",
                MimeType = "text/csv",
                Group = "code",
                Description = "CSV document",
                Extensions = ["csv"],
                IsText = true
            }),
            new(ContentType.Dart, new()
            {
                Label = "dart",
                MimeType = "text/plain",
                Group = "code",
                Description = "Dart source",
                Extensions = ["dart"],
                IsText = true
            }),
            new(ContentType.Deb, new()
            {
                Label = "deb",
                MimeType = "application/vnd.debian.binary-package",
                Group = "archive",
                Description = "Debian binary package",
                Extensions = ["deb"],
                IsText = false
            }),
            new(ContentType.Dex, new()
            {
                Label = "dex",
                MimeType = "application/x-android-dex",
                Group = "executable",
                Description = "Dalvik dex file",
                Extensions = ["dex"],
                IsText = false
            }),
            new(ContentType.Dicom, new()
            {
                Label = "dicom",
                MimeType = "application/dicom",
                Group = "image",
                Description = "DICOM",
                Extensions = ["dcm"],
                IsText = false
            }),
            new(ContentType.Diff, new()
            {
                Label = "diff",
                MimeType = "text/plain",
                Group = "text",
                Description = "Diff file",
                Extensions = ["diff", "patch"],
                IsText = true
            }),
            new(ContentType.Dm, new()
            {
                Label = "dm",
                MimeType = "text/plain",
                Group = "code",
                Description = "Dream Maker",
                Extensions = ["dm"],
                IsText = true
            }),
            new(ContentType.Dmg, new()
            {
                Label = "dmg",
                MimeType = "application/x-apple-diskimage",
                Group = "archive",
                Description = "Apple disk image",
                Extensions = ["dmg"],
                IsText = false
            }),
            new(ContentType.Doc, new()
            {
                Label = "doc",
                MimeType = "application/msword",
                Group = "document",
                Description = "Microsoft Word CDF document",
                Extensions = ["doc"],
                IsText = false
            }),
            new(ContentType.Dockerfile, new()
            {
                Label = "dockerfile",
                MimeType = "text/x-dockerfile",
                Group = "code",
                Description = "Dockerfile",
                Extensions = [],
                IsText = true
            }),
            new(ContentType.Docx, new()
            {
                Label = "docx",
                MimeType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                Group = "document",
                Description = "Microsoft Word 2007+ document",
                Extensions = ["docx", "docm"],
                IsText = false
            }),
            new(ContentType.Dsstore, new()
            {
                Label = "dsstore",
                MimeType = "application/octet-stream",
                Group = "unknown",
                Description = "Application Desktop Services Store",
                Extensions = [],
                IsText = false
            }),
            new(ContentType.Dwg, new()
            {
                Label = "dwg",
                MimeType = "image/x-dwg",
                Group = "image",
                Description = "Autocad Drawing",
                Extensions = ["dwg"],
                IsText = false
            }),
            new(ContentType.Dxf, new()
            {
                Label = "dxf",
                MimeType = "image/vnd.dxf",
                Group = "image",
                Description = "Audocad Drawing Exchange Format",
                Extensions = ["dxf"],
                IsText = true
            }),
            new(ContentType.Elf, new()
            {
                Label = "elf",
                MimeType = "application/x-executable-elf",
                Group = "executable",
                Description = "ELF executable",
                Extensions = ["elf"],
                IsText = false
            }),
            new(ContentType.Elixir, new()
            {
                Label = "elixir",
                MimeType = "text/plain",
                Group = "code",
                Description = "Elixir script",
                Extensions = ["exs"],
                IsText = true
            }),
            new(ContentType.Emf, new()
            {
                Label = "emf",
                MimeType = "application/octet-stream",
                Group = "application",
                Description = "Windows Enhanced Metafile image data",
                Extensions = ["emf"],
                IsText = false
            }),
            new(ContentType.Eml, new()
            {
                Label = "eml",
                MimeType = "message/rfc822",
                Group = "text",
                Description = "RFC 822 mail",
                Extensions = ["eml"],
                IsText = true
            }),
            new(ContentType.Empty, new()
            {
                Label = "empty",
                MimeType = "inode/x-empty",
                Group = "inode",
                Description = "Empty file",
                Extensions = [],
                IsText = false
            }),
            new(ContentType.Epub, new()
            {
                Label = "epub",
                MimeType = "application/epub+zip",
                Group = "document",
                Description = "EPUB document",
                Extensions = ["epub"],
                IsText = false
            }),
            new(ContentType.Erb, new()
            {
                Label = "erb",
                MimeType = "text/x-ruby",
                Group = "code",
                Description = "Embedded Ruby source",
                Extensions = ["erb"],
                IsText = true
            }),
            new(ContentType.Erlang, new()
            {
                Label = "erlang",
                MimeType = "text/x-erlang",
                Group = "code",
                Description = "Erlang source",
                Extensions = ["erl", "hrl"],
                IsText = true
            }),
            new(ContentType.Flac, new()
            {
                Label = "flac",
                MimeType = "audio/flac",
                Group = "audio",
                Description = "FLAC audio bitstream data",
                Extensions = ["flac"],
                IsText = false
            }),
            new(ContentType.Flv, new()
            {
                Label = "flv",
                MimeType = "video/x-flv",
                Group = "video",
                Description = "Flash Video",
                Extensions = ["flv"],
                IsText = false
            }),
            new(ContentType.Fortran, new()
            {
                Label = "fortran",
                MimeType = "text/x-fortran",
                Group = "document",
                Description = "Fortran",
                Extensions = ["f90", "f95", "f03", "F90"],
                IsText = true
            }),
            new(ContentType.Gemfile, new()
            {
                Label = "gemfile",
                MimeType = "text/plain",
                Group = "code",
                Description = "Gemfile file",
                Extensions = [],
                IsText = true
            }),
            new(ContentType.Gemspec, new()
            {
                Label = "gemspec",
                MimeType = "text/plain",
                Group = "code",
                Description = "Gemspec file",
                Extensions = ["gemspec"],
                IsText = true
            }),
            new(ContentType.Gif, new()
            {
                Label = "gif",
                MimeType = "image/gif",
                Group = "image",
                Description = "GIF image data",
                Extensions = ["gif"],
                IsText = false
            }),
            new(ContentType.Gitattributes, new()
            {
                Label = "gitattributes",
                MimeType = "text/plain",
                Group = "code",
                Description = "Gitattributes file",
                Extensions = [],
                IsText = true
            }),
            new(ContentType.Gitmodules, new()
            {
                Label = "gitmodules",
                MimeType = "text/plain",
                Group = "code",
                Description = "Gitmodules file",
                Extensions = [],
                IsText = true
            }),
            new(ContentType.Go, new()
            {
                Label = "go",
                MimeType = "text/x-golang",
                Group = "code",
                Description = "Golang source",
                Extensions = ["go"],
                IsText = true
            }),
            new(ContentType.Gradle, new()
            {
                Label = "gradle",
                MimeType = "text/x-groovy",
                Group = "code",
                Description = "Gradle source",
                Extensions = ["gradle"],
                IsText = true
            }),
            new(ContentType.Groovy, new()
            {
                Label = "groovy",
                MimeType = "text/x-groovy",
                Group = "code",
                Description = "Groovy source",
                Extensions = ["groovy"],
                IsText = true
            }),
            new(ContentType.Gzip, new()
            {
                Label = "gzip",
                MimeType = "application/gzip",
                Group = "archive",
                Description = "gzip compressed data",
                Extensions = ["gz", "gzip", "tgz", "tar.gz"],
                IsText = false
            }),
            new(ContentType.H5, new()
            {
                Label = "h5",
                MimeType = "application/x-hdf5",
                Group = "archive",
                Description = "Hierarchical Data Format v5",
                Extensions = ["h5", "hdf5"],
                IsText = false
            }),
            new(ContentType.Handlebars, new()
            {
                Label = "handlebars",
                MimeType = "text/x-handlebars-template",
                Group = "code",
                Description = "Handlebars source",
                Extensions = ["hbs", "handlebars"],
                IsText = true
            }),
            new(ContentType.Haskell, new()
            {
                Label = "haskell",
                MimeType = "text/plain",
                Group = "code",
                Description = "Haskell source",
                Extensions = ["hs", "lhs"],
                IsText = true
            }),
            new(ContentType.Hcl, new()
            {
                Label = "hcl",
                MimeType = "text/x-hcl",
                Group = "code",
                Description = "HashiCorp configuration language",
                Extensions = ["hcl"],
                IsText = true
            }),
            new(ContentType.Hlp, new()
            {
                Label = "hlp",
                MimeType = "application/winhlp",
                Group = "application",
                Description = "MS Windows help",
                Extensions = ["hlp"],
                IsText = false
            }),
            new(ContentType.Htaccess, new()
            {
                Label = "htaccess",
                MimeType = "text/x-apache-conf",
                Group = "code",
                Description = "Apache access configuration",
                Extensions = [],
                IsText = true
            }),
            new(ContentType.Html, new()
            {
                Label = "html",
                MimeType = "text/html",
                Group = "code",
                Description = "HTML document",
                Extensions = ["html", "htm", "xhtml", "xht"],
                IsText = true
            }),
            new(ContentType.Icns, new()
            {
                Label = "icns",
                MimeType = "image/x-icns",
                Group = "image",
                Description = "Mac OS X icon",
                Extensions = ["icns"],
                IsText = false
            }),
            new(ContentType.Ico, new()
            {
                Label = "ico",
                MimeType = "image/vnd.microsoft.icon",
                Group = "image",
                Description = "MS Windows icon resource",
                Extensions = ["ico"],
                IsText = false
            }),
            new(ContentType.Ics, new()
            {
                Label = "ics",
                MimeType = "text/calendar",
                Group = "application",
                Description = "Internet Calendaring and Scheduling",
                Extensions = ["ics"],
                IsText = true
            }),
            new(ContentType.Ignorefile, new()
            {
                Label = "ignorefile",
                MimeType = "text/plain",
                Group = "code",
                Description = "Ignorefile",
                Extensions = [],
                IsText = true
            }),
            new(ContentType.Ini, new()
            {
                Label = "ini",
                MimeType = "text/plain",
                Group = "text",
                Description = "INI configuration file",
                Extensions = ["ini"],
                IsText = true
            }),
            new(ContentType.Internetshortcut, new()
            {
                Label = "internetshortcut",
                MimeType = "application/x-mswinurl",
                Group = "application",
                Description = "MS Windows Internet shortcut",
                Extensions = ["url"],
                IsText = true
            }),
            new(ContentType.Ipynb, new()
            {
                Label = "ipynb",
                MimeType = "application/json",
                Group = "code",
                Description = "Jupyter notebook",
                Extensions = ["ipynb"],
                IsText = true
            }),
            new(ContentType.Iso, new()
            {
                Label = "iso",
                MimeType = "application/x-iso9660-image",
                Group = "archive",
                Description = "ISO 9660 CD-ROM filesystem data",
                Extensions = ["iso"],
                IsText = false
            }),
            new(ContentType.Jar, new()
            {
                Label = "jar",
                MimeType = "application/java-archive",
                Group = "archive",
                Description = "Java archive data (JAR)",
                Extensions = ["jar", "klib"],
                IsText = false
            }),
            new(ContentType.Java, new()
            {
                Label = "java",
                MimeType = "text/x-java",
                Group = "code",
                Description = "Java source",
                Extensions = ["java"],
                IsText = true
            }),
            new(ContentType.Javabytecode, new()
            {
                Label = "javabytecode",
                MimeType = "application/x-java-applet",
                Group = "executable",
                Description = "Java compiled bytecode",
                Extensions = ["class"],
                IsText = false
            }),
            new(ContentType.Javascript, new()
            {
                Label = "javascript",
                MimeType = "application/javascript",
                Group = "code",
                Description = "JavaScript source",
                Extensions = ["js", "mjs", "cjs"],
                IsText = true
            }),
            new(ContentType.Jinja, new()
            {
                Label = "jinja",
                MimeType = "text/x-jinja2-template",
                Group = "code",
                Description = "Jinja template",
                Extensions = ["jinja", "jinja2", "j2"],
                IsText = true
            }),
            new(ContentType.Jp2, new()
            {
                Label = "jp2",
                MimeType = "image/jpeg2000",
                Group = "image",
                Description = "jpeg2000",
                Extensions = ["jp2"],
                IsText = false
            }),
            new(ContentType.Jpeg, new()
            {
                Label = "jpeg",
                MimeType = "image/jpeg",
                Group = "image",
                Description = "JPEG image data",
                Extensions = ["jpg", "jpeg"],
                IsText = false
            }),
            new(ContentType.Json, new()
            {
                Label = "json",
                MimeType = "application/json",
                Group = "code",
                Description = "JSON document",
                Extensions = ["json"],
                IsText = true
            }),
            new(ContentType.Jsonl, new()
            {
                Label = "jsonl",
                MimeType = "application/json",
                Group = "code",
                Description = "JSONL document",
                Extensions = ["jsonl", "jsonld"],
                IsText = true
            }),
            new(ContentType.Julia, new()
            {
                Label = "julia",
                MimeType = "text/x-julia",
                Group = "code",
                Description = "Julia source",
                Extensions = ["jl"],
                IsText = true
            }),
            new(ContentType.Kotlin, new()
            {
                Label = "kotlin",
                MimeType = "text/plain",
                Group = "code",
                Description = "Kotlin source",
                Extensions = ["kt", "kts"],
                IsText = true
            }),
            new(ContentType.Latex, new()
            {
                Label = "latex",
                MimeType = "text/x-tex",
                Group = "text",
                Description = "LaTeX document",
                Extensions = ["tex", "sty"],
                IsText = true
            }),
            new(ContentType.Lha, new()
            {
                Label = "lha",
                MimeType = "application/x-lha",
                Group = "archive",
                Description = "LHarc archive",
                Extensions = ["lha", "lzh"],
                IsText = false
            }),
            new(ContentType.Lisp, new()
            {
                Label = "lisp",
                MimeType = "text/x-lisp",
                Group = "code",
                Description = "Lisp source",
                Extensions = ["lisp", "lsp", "l", "cl"],
                IsText = true
            }),
            new(ContentType.Lnk, new()
            {
                Label = "lnk",
                MimeType = "application/x-ms-shortcut",
                Group = "application",
                Description = "MS Windows shortcut",
                Extensions = ["lnk"],
                IsText = false
            }),
            new(ContentType.Lua, new()
            {
                Label = "lua",
                MimeType = "text/plain",
                Group = "code",
                Description = "Lua",
                Extensions = ["lua"],
                IsText = true
            }),
            new(ContentType.M3u, new()
            {
                Label = "m3u",
                MimeType = "text/plain",
                Group = "application",
                Description = "M3U playlist",
                Extensions = ["m3u8", "m3u"],
                IsText = true
            }),
            new(ContentType.M4, new()
            {
                Label = "m4",
                MimeType = "text/plain",
                Group = "code",
                Description = "GNU Macro",
                Extensions = ["m4"],
                IsText = true
            }),
            new(ContentType.Macho, new()
            {
                Label = "macho",
                MimeType = "application/x-mach-o",
                Group = "executable",
                Description = "Mach-O executable",
                Extensions = [],
                IsText = false
            }),
            new(ContentType.Makefile, new()
            {
                Label = "makefile",
                MimeType = "text/x-makefile",
                Group = "code",
                Description = "Makefile source",
                Extensions = [],
                IsText = true
            }),
            new(ContentType.Markdown, new()
            {
                Label = "markdown",
                MimeType = "text/markdown",
                Group = "text",
                Description = "Markdown document",
                Extensions = ["md", "markdown"],
                IsText = true
            }),
            new(ContentType.Matlab, new()
            {
                Label = "matlab",
                MimeType = "text/x-matlab",
                Group = "code",
                Description = "Matlab Source",
                Extensions = ["m", "matlab"],
                IsText = true
            }),
            new(ContentType.Mht, new()
            {
                Label = "mht",
                MimeType = "application/x-mimearchive",
                Group = "code",
                Description = "MHTML document",
                Extensions = ["mht"],
                IsText = true
            }),
            new(ContentType.Midi, new()
            {
                Label = "midi",
                MimeType = "audio/midi",
                Group = "audio",
                Description = "Midi",
                Extensions = ["mid"],
                IsText = false
            }),
            new(ContentType.Mkv, new()
            {
                Label = "mkv",
                MimeType = "video/x-matroska",
                Group = "video",
                Description = "Matroska",
                Extensions = ["mkv"],
                IsText = false
            }),
            new(ContentType.Mp3, new()
            {
                Label = "mp3",
                MimeType = "audio/mpeg",
                Group = "audio",
                Description = "MP3 media file",
                Extensions = ["mp3"],
                IsText = false
            }),
            new(ContentType.Mp4, new()
            {
                Label = "mp4",
                MimeType = "video/mp4",
                Group = "video",
                Description = "MP4 media file",
                Extensions = ["mp4"],
                IsText = false
            }),
            new(ContentType.Mscompress, new()
            {
                Label = "mscompress",
                MimeType = "application/x-ms-compress-szdd",
                Group = "archive",
                Description = "MS Compress archive data",
                Extensions = [],
                IsText = false
            }),
            new(ContentType.Msi, new()
            {
                Label = "msi",
                MimeType = "application/x-msi",
                Group = "archive",
                Description = "Microsoft Installer file",
                Extensions = ["msi"],
                IsText = false
            }),
            new(ContentType.Mum, new()
            {
                Label = "mum",
                MimeType = "text/xml",
                Group = "application",
                Description = "Windows Update Package file",
                Extensions = ["mum"],
                IsText = true
            }),
            new(ContentType.Npy, new()
            {
                Label = "npy",
                MimeType = "application/octet-stream",
                Group = "archive",
                Description = "Numpy Array",
                Extensions = ["npy"],
                IsText = false
            }),
            new(ContentType.Npz, new()
            {
                Label = "npz",
                MimeType = "application/octet-stream",
                Group = "archive",
                Description = "Numpy Arrays Archive",
                Extensions = ["npz"],
                IsText = false
            }),
            new(ContentType.Nupkg, new()
            {
                Label = "nupkg",
                MimeType = "application/octet-stream",
                Group = "unknown",
                Description = "NuGet Package",
                Extensions = ["nupkg"],
                IsText = false
            }),
            new(ContentType.Objectivec, new()
            {
                Label = "objectivec",
                MimeType = "text/x-objcsrc",
                Group = "code",
                Description = "ObjectiveC source",
                Extensions = ["m", "mm"],
                IsText = true
            }),
            new(ContentType.Ocaml, new()
            {
                Label = "ocaml",
                MimeType = "text-ocaml",
                Group = "code",
                Description = "OCaml",
                Extensions = ["ml", "mli"],
                IsText = true
            }),
            new(ContentType.Odp, new()
            {
                Label = "odp",
                MimeType = "application/vnd.oasis.opendocument.presentation",
                Group = "document",
                Description = "OpenDocument Presentation",
                Extensions = ["odp"],
                IsText = false
            }),
            new(ContentType.Ods, new()
            {
                Label = "ods",
                MimeType = "application/vnd.oasis.opendocument.spreadsheet",
                Group = "document",
                Description = "OpenDocument Spreadsheet",
                Extensions = ["ods"],
                IsText = false
            }),
            new(ContentType.Odt, new()
            {
                Label = "odt",
                MimeType = "application/vnd.oasis.opendocument.text",
                Group = "document",
                Description = "OpenDocument Text",
                Extensions = ["odt"],
                IsText = false
            }),
            new(ContentType.Ogg, new()
            {
                Label = "ogg",
                MimeType = "audio/ogg",
                Group = "audio",
                Description = "Ogg data",
                Extensions = ["ogg"],
                IsText = false
            }),
            new(ContentType.One, new()
            {
                Label = "one",
                MimeType = "application/msonenote",
                Group = "document",
                Description = "One Note",
                Extensions = ["one"],
                IsText = false
            }),
            new(ContentType.Onnx, new()
            {
                Label = "onnx",
                MimeType = "application/octet-stream",
                Group = "archive",
                Description = "Open Neural Network Exchange",
                Extensions = ["onnx"],
                IsText = false
            }),
            new(ContentType.Otf, new()
            {
                Label = "otf",
                MimeType = "font/otf",
                Group = "font",
                Description = "OpenType font",
                Extensions = ["otf"],
                IsText = false
            }),
            new(ContentType.Outlook, new()
            {
                Label = "outlook",
                MimeType = "application/vnd.ms-outlook",
                Group = "application",
                Description = "MS Outlook Message",
                Extensions = [],
                IsText = false
            }),
            new(ContentType.Parquet, new()
            {
                Label = "parquet",
                MimeType = "application/vnd.apache.parquet",
                Group = "unknown",
                Description = "Apache Parquet",
                Extensions = ["pqt", "parquet"],
                IsText = false
            }),
            new(ContentType.Pascal, new()
            {
                Label = "pascal",
                MimeType = "text/x-pascal",
                Group = "code",
                Description = "Pascal source",
                Extensions = ["pas", "pp"],
                IsText = true
            }),
            new(ContentType.Pcap, new()
            {
                Label = "pcap",
                MimeType = "application/vnd.tcpdump.pcap",
                Group = "application",
                Description = "pcap capture file",
                Extensions = ["pcap", "pcapng"],
                IsText = false
            }),
            new(ContentType.Pdb, new()
            {
                Label = "pdb",
                MimeType = "application/octet-stream",
                Group = "application",
                Description = "Windows Program Database",
                Extensions = ["pdb"],
                IsText = false
            }),
            new(ContentType.Pdf, new()
            {
                Label = "pdf",
                MimeType = "application/pdf",
                Group = "document",
                Description = "PDF document",
                Extensions = ["pdf"],
                IsText = false
            }),
            new(ContentType.Pebin, new()
            {
                Label = "pebin",
                MimeType = "application/x-dosexec",
                Group = "executable",
                Description = "PE Windows executable",
                Extensions = ["exe", "dll"],
                IsText = false
            }),
            new(ContentType.Pem, new()
            {
                Label = "pem",
                MimeType = "application/x-pem-file",
                Group = "application",
                Description = "PEM certificate",
                Extensions = ["pem", "pub", "gpg"],
                IsText = true
            }),
            new(ContentType.Perl, new()
            {
                Label = "perl",
                MimeType = "text/x-perl",
                Group = "code",
                Description = "Perl source",
                Extensions = ["pl"],
                IsText = true
            }),
            new(ContentType.Php, new()
            {
                Label = "php",
                MimeType = "text/x-php",
                Group = "code",
                Description = "PHP source",
                Extensions = ["php"],
                IsText = true
            }),
            new(ContentType.Pickle, new()
            {
                Label = "pickle",
                MimeType = "application/octet-stream",
                Group = "application",
                Description = "Python pickle",
                Extensions = ["pickle", "pkl"],
                IsText = false
            }),
            new(ContentType.Png, new()
            {
                Label = "png",
                MimeType = "image/png",
                Group = "image",
                Description = "PNG image",
                Extensions = ["png"],
                IsText = false
            }),
            new(ContentType.Po, new()
            {
                Label = "po",
                MimeType = "text/gettext-translation",
                Group = "application",
                Description = "Portable Object (PO) for i18n",
                Extensions = ["po"],
                IsText = true
            }),
            new(ContentType.Postscript, new()
            {
                Label = "postscript",
                MimeType = "application/postscript",
                Group = "document",
                Description = "PostScript document",
                Extensions = ["ps"],
                IsText = false
            }),
            new(ContentType.Powershell, new()
            {
                Label = "powershell",
                MimeType = "application/x-powershell",
                Group = "code",
                Description = "Powershell source",
                Extensions = ["ps1"],
                IsText = true
            }),
            new(ContentType.Ppt, new()
            {
                Label = "ppt",
                MimeType = "application/vnd.ms-powerpoint",
                Group = "document",
                Description = "Microsoft PowerPoint CDF document",
                Extensions = ["ppt"],
                IsText = false
            }),
            new(ContentType.Pptx, new()
            {
                Label = "pptx",
                MimeType = "application/vnd.openxmlformats-officedocument.presentationml.presentation",
                Group = "document",
                Description = "Microsoft PowerPoint 2007+ document",
                Extensions = ["pptx", "pptm"],
                IsText = false
            }),
            new(ContentType.Prolog, new()
            {
                Label = "prolog",
                MimeType = "text/x-prolog",
                Group = "code",
                Description = "Prolog source",
                Extensions = ["pl", "pro", "P"],
                IsText = true
            }),
            new(ContentType.Proteindb, new()
            {
                Label = "proteindb",
                MimeType = "application/octet-stream",
                Group = "application",
                Description = "Protein DB",
                Extensions = ["pdb"],
                IsText = true
            }),
            new(ContentType.Proto, new()
            {
                Label = "proto",
                MimeType = "text/x-proto",
                Group = "code",
                Description = "Protocol buffer definition",
                Extensions = ["proto"],
                IsText = true
            }),
            new(ContentType.Psd, new()
            {
                Label = "psd",
                MimeType = "image/vnd.adobe.photoshop",
                Group = "image",
                Description = "Adobe Photoshop",
                Extensions = ["psd"],
                IsText = false
            }),
            new(ContentType.Python, new()
            {
                Label = "python",
                MimeType = "text/x-python",
                Group = "code",
                Description = "Python source",
                Extensions = ["py", "pyi"],
                IsText = true
            }),
            new(ContentType.Pythonbytecode, new()
            {
                Label = "pythonbytecode",
                MimeType = "application/x-bytecode.python",
                Group = "executable",
                Description = "Python compiled bytecode",
                Extensions = ["pyc", "pyo"],
                IsText = false
            }),
            new(ContentType.Pytorch, new()
            {
                Label = "pytorch",
                MimeType = "application/octet-stream",
                Group = "application",
                Description = "Pytorch storage file",
                Extensions = ["pt", "pth"],
                IsText = false
            }),
            new(ContentType.Qt, new()
            {
                Label = "qt",
                MimeType = "video/quicktime",
                Group = "video",
                Description = "QuickTime",
                Extensions = ["mov"],
                IsText = false
            }),
            new(ContentType.R, new()
            {
                Label = "r",
                MimeType = "text/x-R",
                Group = "code",
                Description = "R (language)",
                Extensions = ["R"],
                IsText = true
            }),
            new(ContentType.Randombytes, new()
            {
                Label = "randombytes",
                MimeType = "application/octet-stream",
                Group = "unknown",
                Description = "Random bytes",
                Extensions = [],
                IsText = false
            }),
            new(ContentType.Randomtxt, new()
            {
                Label = "randomtxt",
                MimeType = "text/plain",
                Group = "text",
                Description = "Random text",
                Extensions = [],
                IsText = true
            }),
            new(ContentType.Rar, new()
            {
                Label = "rar",
                MimeType = "application/x-rar",
                Group = "archive",
                Description = "RAR archive data",
                Extensions = ["rar"],
                IsText = false
            }),
            new(ContentType.Rdf, new()
            {
                Label = "rdf",
                MimeType = "application/rdf+xml",
                Group = "text",
                Description = "Resource Description Framework document (RDF)",
                Extensions = ["rdf"],
                IsText = true
            }),
            new(ContentType.Rpm, new()
            {
                Label = "rpm",
                MimeType = "application/x-rpm",
                Group = "archive",
                Description = "RedHat Package Manager archive (RPM)",
                Extensions = ["rpm"],
                IsText = false
            }),
            new(ContentType.Rst, new()
            {
                Label = "rst",
                MimeType = "text/x-rst",
                Group = "text",
                Description = "ReStructuredText document",
                Extensions = ["rst"],
                IsText = true
            }),
            new(ContentType.Rtf, new()
            {
                Label = "rtf",
                MimeType = "text/rtf",
                Group = "text",
                Description = "Rich Text Format document",
                Extensions = ["rtf"],
                IsText = true
            }),
            new(ContentType.Ruby, new()
            {
                Label = "ruby",
                MimeType = "application/x-ruby",
                Group = "code",
                Description = "Ruby source",
                Extensions = ["rb"],
                IsText = true
            }),
            new(ContentType.Rust, new()
            {
                Label = "rust",
                MimeType = "application/x-rust",
                Group = "code",
                Description = "Rust source",
                Extensions = ["rs"],
                IsText = true
            }),
            new(ContentType.Scala, new()
            {
                Label = "scala",
                MimeType = "application/x-scala",
                Group = "code",
                Description = "Scala source",
                Extensions = ["scala"],
                IsText = true
            }),
            new(ContentType.Scss, new()
            {
                Label = "scss",
                MimeType = "text/x-scss",
                Group = "code",
                Description = "SCSS source",
                Extensions = ["scss"],
                IsText = true
            }),
            new(ContentType.Sevenzip, new()
            {
                Label = "sevenzip",
                MimeType = "application/x-7z-compressed",
                Group = "archive",
                Description = "7-zip archive data",
                Extensions = ["7z"],
                IsText = false
            }),
            new(ContentType.Sgml, new()
            {
                Label = "sgml",
                MimeType = "application/sgml",
                Group = "text",
                Description = "sgml",
                Extensions = ["sgml"],
                IsText = true
            }),
            new(ContentType.Shell, new()
            {
                Label = "shell",
                MimeType = "text/x-shellscript",
                Group = "code",
                Description = "Shell script",
                Extensions = ["sh"],
                IsText = true
            }),
            new(ContentType.Smali, new()
            {
                Label = "smali",
                MimeType = "application/x-smali",
                Group = "code",
                Description = "Smali source",
                Extensions = ["smali"],
                IsText = true
            }),
            new(ContentType.Snap, new()
            {
                Label = "snap",
                MimeType = "application/octet-stream",
                Group = "archive",
                Description = "Snap archive",
                Extensions = ["snap"],
                IsText = false
            }),
            new(ContentType.Solidity, new()
            {
                Label = "solidity",
                MimeType = "text/plain",
                Group = "code",
                Description = "Solidity source",
                Extensions = ["sol"],
                IsText = true
            }),
            new(ContentType.Sql, new()
            {
                Label = "sql",
                MimeType = "application/x-sql",
                Group = "code",
                Description = "SQL source",
                Extensions = ["sql"],
                IsText = true
            }),
            new(ContentType.Sqlite, new()
            {
                Label = "sqlite",
                MimeType = "application/octet-stream",
                Group = "application",
                Description = "SQLITE database",
                Extensions = ["sqlite", "sqlite3"],
                IsText = false
            }),
            new(ContentType.Squashfs, new()
            {
                Label = "squashfs",
                MimeType = "application/octet-stream",
                Group = "archive",
                Description = "Squash filesystem",
                Extensions = [],
                IsText = false
            }),
            new(ContentType.Srt, new()
            {
                Label = "srt",
                MimeType = "text/srt",
                Group = "application",
                Description = "SubRip Text Format",
                Extensions = ["srt"],
                IsText = true
            }),
            new(ContentType.Stlbinary, new()
            {
                Label = "stlbinary",
                MimeType = "application/sla",
                Group = "image",
                Description = "Stereolithography CAD (binary)",
                Extensions = ["stl"],
                IsText = false
            }),
            new(ContentType.Stltext, new()
            {
                Label = "stltext",
                MimeType = "application/sla",
                Group = "image",
                Description = "Stereolithography CAD (text)",
                Extensions = ["stl"],
                IsText = true
            }),
            new(ContentType.Sum, new()
            {
                Label = "sum",
                MimeType = "text/plain",
                Group = "application",
                Description = "Checksum file",
                Extensions = ["sum"],
                IsText = true
            }),
            new(ContentType.Svg, new()
            {
                Label = "svg",
                MimeType = "image/svg+xml",
                Group = "image",
                Description = "SVG Scalable Vector Graphics image data",
                Extensions = ["svg"],
                IsText = true
            }),
            new(ContentType.Swf, new()
            {
                Label = "swf",
                MimeType = "application/x-shockwave-flash",
                Group = "executable",
                Description = "Small Web File",
                Extensions = ["swf"],
                IsText = false
            }),
            new(ContentType.Swift, new()
            {
                Label = "swift",
                MimeType = "text/x-swift",
                Group = "code",
                Description = "Swift",
                Extensions = ["swift"],
                IsText = true
            }),
            new(ContentType.Tar, new()
            {
                Label = "tar",
                MimeType = "application/x-tar",
                Group = "archive",
                Description = "POSIX tar archive",
                Extensions = ["tar"],
                IsText = false
            }),
            new(ContentType.Tcl, new()
            {
                Label = "tcl",
                MimeType = "application/x-tcl",
                Group = "code",
                Description = "Tickle",
                Extensions = ["tcl"],
                IsText = true
            }),
            new(ContentType.Textproto, new()
            {
                Label = "textproto",
                MimeType = "text/plain",
                Group = "code",
                Description = "Text protocol buffer",
                Extensions = ["textproto", "textpb", "pbtxt"],
                IsText = true
            }),
            new(ContentType.Tga, new()
            {
                Label = "tga",
                MimeType = "image/x-tga",
                Group = "image",
                Description = "Targa image data",
                Extensions = ["tga"],
                IsText = false
            }),
            new(ContentType.Thumbsdb, new()
            {
                Label = "thumbsdb",
                MimeType = "image/vnd.ms-thumb",
                Group = "application",
                Description = "Windows thumbnail cache",
                Extensions = [],
                IsText = false
            }),
            new(ContentType.Tiff, new()
            {
                Label = "tiff",
                MimeType = "image/tiff",
                Group = "image",
                Description = "TIFF image data",
                Extensions = ["tiff", "tif"],
                IsText = false
            }),
            new(ContentType.Toml, new()
            {
                Label = "toml",
                MimeType = "application/toml",
                Group = "text",
                Description = "Tom's obvious, minimal language",
                Extensions = ["toml"],
                IsText = true
            }),
            new(ContentType.Torrent, new()
            {
                Label = "torrent",
                MimeType = "application/x-bittorrent",
                Group = "application",
                Description = "BitTorrent file",
                Extensions = ["torrent"],
                IsText = false
            }),
            new(ContentType.Tsv, new()
            {
                Label = "tsv",
                MimeType = "text/tsv",
                Group = "code",
                Description = "TSV document",
                Extensions = ["tsv"],
                IsText = true
            }),
            new(ContentType.Ttf, new()
            {
                Label = "ttf",
                MimeType = "font/sfnt",
                Group = "font",
                Description = "TrueType Font data",
                Extensions = ["ttf", "ttc"],
                IsText = false
            }),
            new(ContentType.Twig, new()
            {
                Label = "twig",
                MimeType = "text/x-twig",
                Group = "code",
                Description = "Twig template",
                Extensions = ["twig"],
                IsText = true
            }),
            new(ContentType.Txt, new()
            {
                Label = "txt",
                MimeType = "text/plain",
                Group = "text",
                Description = "Generic text document",
                Extensions = ["txt"],
                IsText = true
            }),
            new(ContentType.Typescript, new()
            {
                Label = "typescript",
                MimeType = "application/typescript",
                Group = "code",
                Description = "TypeScript source",
                Extensions = ["ts", "mts", "cts"],
                IsText = true
            }),
            new(ContentType.Undefined, new()
            {
                Label = "undefined",
                MimeType = "application/undefined",
                Group = "undefined",
                Description = "Undefined",
                Extensions = [],
                IsText = false
            }),
            new(ContentType.Unknown, new()
            {
                Label = "unknown",
                MimeType = "application/octet-stream",
                Group = "unknown",
                Description = "Unknown binary data",
                Extensions = [],
                IsText = false
            }),
            new(ContentType.Vba, new()
            {
                Label = "vba",
                MimeType = "text/vbscript",
                Group = "code",
                Description = "MS Visual Basic source (VBA)",
                Extensions = ["vbs", "vba", "vb"],
                IsText = true
            }),
            new(ContentType.Vcxproj, new()
            {
                Label = "vcxproj",
                MimeType = "application/xml",
                Group = "code",
                Description = "Visual Studio MSBuild project",
                Extensions = ["vcxproj"],
                IsText = true
            }),
            new(ContentType.Verilog, new()
            {
                Label = "verilog",
                MimeType = "text/x-verilog",
                Group = "code",
                Description = "Verilog source",
                Extensions = ["v", "verilog", "vlg", "vh"],
                IsText = true
            }),
            new(ContentType.Vhdl, new()
            {
                Label = "vhdl",
                MimeType = "text/x-vhdl",
                Group = "code",
                Description = "VHDL source",
                Extensions = ["vhd"],
                IsText = true
            }),
            new(ContentType.Vtt, new()
            {
                Label = "vtt",
                MimeType = "text/vtt",
                Group = "text",
                Description = "Web Video Text Tracks",
                Extensions = ["vtt", "webvtt"],
                IsText = true
            }),
            new(ContentType.Vue, new()
            {
                Label = "vue",
                MimeType = "application/javascript",
                Group = "code",
                Description = "Vue source",
                Extensions = ["vue"],
                IsText = true
            }),
            new(ContentType.Wasm, new()
            {
                Label = "wasm",
                MimeType = "application/wasm",
                Group = "executable",
                Description = "Web Assembly",
                Extensions = ["wasm"],
                IsText = false
            }),
            new(ContentType.Wav, new()
            {
                Label = "wav",
                MimeType = "audio/x-wav",
                Group = "audio",
                Description = "Waveform Audio file (WAV)",
                Extensions = ["wav"],
                IsText = false
            }),
            new(ContentType.Webm, new()
            {
                Label = "webm",
                MimeType = "video/webm",
                Group = "video",
                Description = "WebM media file",
                Extensions = ["webm"],
                IsText = false
            }),
            new(ContentType.Webp, new()
            {
                Label = "webp",
                MimeType = "image/webp",
                Group = "image",
                Description = "WebP media file",
                Extensions = ["webp"],
                IsText = false
            }),
            new(ContentType.Winregistry, new()
            {
                Label = "winregistry",
                MimeType = "text/x-ms-regedit",
                Group = "application",
                Description = "Windows Registry text",
                Extensions = ["reg"],
                IsText = true
            }),
            new(ContentType.Wmf, new()
            {
                Label = "wmf",
                MimeType = "image/wmf",
                Group = "image",
                Description = "Windows metafile",
                Extensions = ["wmf"],
                IsText = false
            }),
            new(ContentType.Woff, new()
            {
                Label = "woff",
                MimeType = "font/woff",
                Group = "font",
                Description = "Web Open Font Format",
                Extensions = ["woff"],
                IsText = false
            }),
            new(ContentType.Woff2, new()
            {
                Label = "woff2",
                MimeType = "font/woff2",
                Group = "font",
                Description = "Web Open Font Format v2",
                Extensions = ["woff2"],
                IsText = false
            }),
            new(ContentType.Xar, new()
            {
                Label = "xar",
                MimeType = "application/x-xar",
                Group = "archive",
                Description = "XAR archive compressed data",
                Extensions = ["pkg", "xar"],
                IsText = false
            }),
            new(ContentType.Xls, new()
            {
                Label = "xls",
                MimeType = "application/vnd.ms-excel",
                Group = "document",
                Description = "Microsoft Excel CDF document",
                Extensions = ["xls"],
                IsText = false
            }),
            new(ContentType.Xlsb, new()
            {
                Label = "xlsb",
                MimeType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                Group = "document",
                Description = "Microsoft Excel 2007+ document (binary format)",
                Extensions = ["xlsb"],
                IsText = false
            }),
            new(ContentType.Xlsx, new()
            {
                Label = "xlsx",
                MimeType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                Group = "document",
                Description = "Microsoft Excel 2007+ document",
                Extensions = ["xlsx", "xlsm"],
                IsText = false
            }),
            new(ContentType.Xml, new()
            {
                Label = "xml",
                MimeType = "text/xml",
                Group = "code",
                Description = "XML document",
                Extensions = ["xml"],
                IsText = true
            }),
            new(ContentType.Xpi, new()
            {
                Label = "xpi",
                MimeType = "application/zip",
                Group = "archive",
                Description = "Compressed installation archive (XPI)",
                Extensions = ["xpi"],
                IsText = false
            }),
            new(ContentType.Xz, new()
            {
                Label = "xz",
                MimeType = "application/x-xz",
                Group = "archive",
                Description = "XZ compressed data",
                Extensions = ["xz"],
                IsText = false
            }),
            new(ContentType.Yaml, new()
            {
                Label = "yaml",
                MimeType = "application/x-yaml",
                Group = "code",
                Description = "YAML source",
                Extensions = ["yml", "yaml"],
                IsText = true
            }),
            new(ContentType.Yara, new()
            {
                Label = "yara",
                MimeType = "text/x-yara",
                Group = "code",
                Description = "YARA rule",
                Extensions = ["yar", "yara"],
                IsText = true
            }),
            new(ContentType.Zig, new()
            {
                Label = "zig",
                MimeType = "text/zig",
                Group = "code",
                Description = "Zig source",
                Extensions = ["zig"],
                IsText = true
            }),
            new(ContentType.Zip, new()
            {
                Label = "zip",
                MimeType = "application/zip",
                Group = "archive",
                Description = "Zip archive data",
                Extensions = ["zip"],
                IsText = false
            }),
            new(ContentType.Zlibstream, new()
            {
                Label = "zlibstream",
                MimeType = "application/zlib",
                Group = "application",
                Description = "zlib compressed data",
                Extensions = [],
                IsText = false
            }),
            new(ContentType.Directory, new()
            {
                Label = "directory",
                MimeType = "inode/directory",
                Group = "inode",
                Description = "A directory",
                Extensions = [],
                IsText = false
            }),
            new(ContentType.Symlink, new()
            {
                Label = "symlink",
                MimeType = "inode/symlink",
                Group = "inode",
                Description = "Symbolic link",
                Extensions = [],
                IsText = false
            })
        );
}