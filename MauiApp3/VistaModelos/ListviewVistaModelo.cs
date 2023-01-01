using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp3.Modelos;
using System.Collections.ObjectModel;

namespace MauiApp3.VistaModelos;

public partial class ListviewVistaModelo : ObservableObject
{
    public ListviewVistaModelo()
    {
        Actividades = new()
        {
            new(){ Dia="Lunes", HorarioEntrada="07:00 AM", HorarioSalida="05:00 PM", NoActividades="12 Actividades"},
            new(){ Dia="Martes", HorarioEntrada="07:00 AM", HorarioSalida="05:00 PM", NoActividades="8 Actividades"},
            new(){ Dia="Miércoles", HorarioEntrada="07:00 AM", HorarioSalida="05:00 PM", NoActividades="7 Actividades"},
            new(){ Dia="Jueves", HorarioEntrada="07:00 AM", HorarioSalida="05:00 PM", NoActividades="No hay actividades"},
            new(){ Dia="Viernes", HorarioEntrada="07:00 AM", HorarioSalida="05:00 PM", NoActividades="5 Actividades"},
            new(){ Dia="Sábado", HorarioEntrada="07:00 AM", HorarioSalida="01:00 PM", NoActividades="1 Actividad"},
        };

    }

    [ObservableProperty]
    private ObservableCollection<Actividad> actividades;

    [ObservableProperty]
    private Actividad selectedActividad;
}
