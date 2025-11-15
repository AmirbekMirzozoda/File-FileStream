using QRCoder;

// текст или ссылка, из которой нужно сделать QR
string qrText = "https://cdn.pixabay.com/photo/2024/05/26/10/15/bird-8788491_1280.jpg";

// создаём QR
var generator = new QRCodeGenerator();
var data = generator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);

// генерируем PNG как массив байтов
var pngQr = new PngByteQRCode(data);
byte[] qrBytes = pngQr.GetGraphic(20);

// путь
string outputPath = Path.Combine("qr", "qrcode.png");
Directory.CreateDirectory("qr");

// сохраняем файл
File.WriteAllBytes(outputPath, qrBytes);