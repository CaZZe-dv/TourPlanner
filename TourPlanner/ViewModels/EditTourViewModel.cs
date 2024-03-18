using Npgsql.Replication.PgOutput.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TourPlanner.Commands;
using TourPlanner.Models;
using TourPlanner.Services;

namespace TourPlanner.ViewModels
{
    public class EditTourViewModel : ViewModelBase
    {
        private string _editTourName;
        public string EditTourName
        {
            get => _editTourName;
            set
            {
                _editTourName = value;
                OnPropertyChanged(nameof(EditTourName));
            }
        }

        private string _editTourDescription;
        public string EditTourDescription
        {
            get => _editTourDescription;
            set
            {
                _editTourDescription = value;
                OnPropertyChanged(nameof(EditTourDescription));
            }
        }

        private string _editTourFrom;
        public string EditTourFrom
        {
            get => _editTourFrom;
            set
            {
                _editTourFrom = value;
                OnPropertyChanged(nameof(EditTourFrom));
            }
        }

        private string _editTourTo;
        public string EditTourTo
        {
            get => _editTourTo;
            set
            {
                _editTourTo = value;
                OnPropertyChanged(nameof(EditTourTo));
            }
        }

        private string _editTourTransportType;
        public string EditTourTransportType
        {
            get => _editTourTransportType;
            set
            {
                _editTourTransportType = value;
                OnPropertyChanged(nameof(EditTourTransportType));
            }
        }

        public ICommand UpdateEditTourCommand { get; }
        public ICommand CancelEditTourCommand { get; }

        public EditTourViewModel(TourPlannerManager tourPlannerManager, NavigationService navigationService)
        {
            UpdateEditTourCommand = new UpdateEditTourCommand(this,tourPlannerManager,navigationService);
            CancelEditTourCommand = new CancelEditTourCommand(navigationService);
        }
    }
}
