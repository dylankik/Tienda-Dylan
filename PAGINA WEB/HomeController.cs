public IActionResult Productos()
{
    return View();
}

public IActionResult Contacto()
{
    return View();
}

[HttpPost]
public IActionResult Contacto(string nombre, string email, string mensaje)
{
    // Aquí puedes implementar el envío de correo o almacenamiento del mensaje.
    ViewBag.Mensaje = "Gracias por contactarnos. Nos pondremos en contacto contigo pronto.";
    return View();
}
